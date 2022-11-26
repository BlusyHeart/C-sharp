using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Animal.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int consumedFood) : base(name, weight, consumedFood)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
