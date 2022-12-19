using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private int destructionLevel;

        protected Weapon(int destructionLevel, double price)
        {
            this.DestructionLevel = destructionLevel;
            Price = price;
        }

        public double Price { get; }

     
        public int DestructionLevel
        {
            get 
            { 
                return destructionLevel; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);
                }
                else if (value > 10)
                {
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);
                }
                else
                {
                    destructionLevel = value;
                }               
            }
        }

    }
}
