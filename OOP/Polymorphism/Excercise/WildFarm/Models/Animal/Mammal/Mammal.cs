using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animal.Mammal
{
    public class Mammal : Animal, IMammal
    {
        public Mammal(string name, double weight, int consumedFood) : base(name, weight, consumedFood)
        {
        }

        public string LivingRegion { get; set ; }
        
    }
}
