using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        private string name;
        private int power;

        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get ; private set; }

        public int Power { get ; private set ; }

        public string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
