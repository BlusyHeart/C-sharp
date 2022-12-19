using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {
        private int enduranceLevel = 1;

        protected MilitaryUnit(double cost)
        {
            Cost = cost;
        }

        public double Cost { get; }

        public int EnduranceLevel => enduranceLevel;

        public void IncreaseEndurance()
        {           
            if (enduranceLevel + 1 > 20)
            {
                enduranceLevel = 20;
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }
            enduranceLevel += 1;
        }
    }
}
