using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;
using WildFarm.Models.Animal.Mammal;

namespace WildFarm.Models.Animal.Feline
{
    public abstract class Feline : IMammal, IFeline
    {
        protected Feline(string livingRegion, string breed)
        {
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public string LivingRegion { get ; set ; }
        public string Breed { get ; set ; }
    }
}
