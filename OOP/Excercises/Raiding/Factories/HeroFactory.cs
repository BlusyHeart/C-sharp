using Raiding.Factories.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public BaseHero CreateHero(string name, string heroType)
        {
            BaseHero baseHero;

            if (heroType == "Druid")
            {
                baseHero = new Druid(name);
            }
            else if (heroType == "Paladin")
            {
                baseHero = new Paladin(name);
            }
            else if (heroType == "Rogue")
            {
                baseHero = new Rogue(name);
            }
            else if (heroType == "Warrior")
            {
                baseHero = new Warrior(name);
            }
            else
            {
                throw new InvalidOperationException("Invalid hero!");
            }

            return baseHero;
        }
    }
}
