using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace AquaShop.Core
{
    public class Controller : IController
    {

        List<IAquarium> aquariums = new List<IAquarium>();
        DecorationRepository decorations = new DecorationRepository();

        public Controller()
        {
            aquariums = new List<IAquarium>();
            decorations = new DecorationRepository();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != nameof(FreshwaterAquarium) && aquariumType != nameof(SaltwaterAquarium))
            {
                throw new ArgumentException(ExceptionMessages.InvalidAquariumType);
            }

            IAquarium aquarium;
            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            aquariums.Add(aquarium);

            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != nameof(Ornament) && decorationType != nameof(Plant))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            IDecoration decoration;
            if (decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }
            else
            {
                decoration = new Plant();
            }
            decorations.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
            IFish fish;

            IAquarium aquarium;
            aquarium = aquariums.Find(a => a.Name == aquariumName);

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
                if (aquarium.GetType().Name == nameof(SaltwaterAquarium))
                {
                   return "Water not suitable.";
                }
            }
            else
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
                if (aquarium.GetType().Name == nameof(FreshwaterAquarium))
                {
                    return "Water not suitable.";
                }
            }
            aquarium.AddFish(fish);
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);

        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium;
            aquarium = aquariums.Find(a => a.Name == aquariumName);
            decimal decorationSum = aquarium.Decorations.Sum(d => d.Price);
            decimal fishsSum = aquarium.Fish.Sum(f => f.Price);
            decimal aquariumSum = decorationSum + fishsSum;
            return $"The value of Aquarium {aquariumName} is {aquariumSum:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium;
            aquarium = aquariums.Find(a => a.Name == aquariumName);
            aquarium.Feed();
            return aquarium.Fish.Count.ToString();
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration;
            decoration = decorations.FindByType(decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDecoration);
            }

            IAquarium aquarium;
            aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aquarium.AddDecoration(decoration);
            decorations.Remove(decoration);
            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IAquarium aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
