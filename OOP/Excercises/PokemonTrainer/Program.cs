using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, Trainer> trainers = new SortedDictionary<string, Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                string[] trainerData = input.Split();

                string name = trainerData[0];
                string pokemonName = trainerData[1];
                string pokemonElement = trainerData[2];
                int pokemonHealth = int.Parse(trainerData[3]);

                if (!trainers.ContainsKey(name))
                {
                    Trainer newTrainer = new Trainer(name);
                    trainers.Add(name, newTrainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = trainers[name];
                trainer.pokemonCollection.Add(pokemon);

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string element = input;

                foreach (KeyValuePair<string, Trainer> trainersName in trainers)
                {

                    if (trainersName.Value.pokemonCollection.Any(pokemon => pokemon.Element == input))
                    {
                        trainersName.Value.NumberOfBadges += 1;
                    }
                    else
                    {
                        trainersName.Value.pokemonCollection = trainersName.Value.pokemonCollection
                            .Where(pokemon => pokemon.Health - 10 > 0).ToList();
                    }
                }
            }
            foreach (KeyValuePair<string, Trainer> name in trainers.OrderByDescending(name => name.Value.NumberOfBadges))
            {
                Console.WriteLine($"{name.Key} {name.Value.NumberOfBadges} {name.Value.pokemonCollection.Count}");
            }

        }
    }
}





