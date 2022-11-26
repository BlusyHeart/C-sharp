using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight, int consumedFood)
        {
            Name = name;
            Weight = weight;
            ConsumedFood = consumedFood;
        }

        protected abstract IReadOnlyCollection<Type> PreferredFoods { get; }

        public string Name { get; }
        public double Weight { get; }
        public int ConsumedFood { get; }
        
        public abstract string ProduceSound();

        public virtual void Eat(Food food)
        {

        }
    }
}
