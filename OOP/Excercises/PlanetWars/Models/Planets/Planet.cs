using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private readonly UnitRepository unitRepository;
        private readonly WeaponRepository weaponRepository;
        private string name;
        private double budget;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
            unitRepository = new UnitRepository();
            weaponRepository = new WeaponRepository();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                name = value; 
            }
        }

        public double Budget
        {
            get { return budget; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }
                budget = value; 
            }
        }

        public double MilitaryPower => GetMilitaryPower();

        public IReadOnlyCollection<IMilitaryUnit> Army => unitRepository.Models;

        public IReadOnlyCollection<IWeapon> Weapons => weaponRepository.Models;

        public void AddUnit(IMilitaryUnit unit) => unitRepository.AddItem(unit);
        
        public void AddWeapon(IWeapon weapon) => weaponRepository.AddItem(weapon);
       
        public string PlanetInfo()
        {
            StringBuilder sb = new StringBuilder();
            string forcesResult = Army.Any() ? string.Join(", ", Army.Select(u => u.GetType().Name)) : "No units";
            string weaponsResult = Weapons.Any() ? string.Join(", ", Weapons.Select(u => u.GetType().Name)) : "No weapons";

            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            sb.AppendLine($"--Forces: {forcesResult}");
            sb.AppendLine($"--Combat equipment: {weaponsResult}");
            sb.AppendLine($"--Military Power: {MilitaryPower}");

            return sb.ToString().TrimEnd();
        }

        public void Profit(double amount)
        {
            Budget += amount;
        }

        public void Spend(double amount)
        {
            if (amount > budget)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }
            Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (IMilitaryUnit unit in Army)
            {
                unit.IncreaseEndurance();
            }
        }
        
        private double GetMilitaryPower()
        {
            double totalAmount = unitRepository.Models.Sum(u => u.EnduranceLevel) 
                + weaponRepository.Models.Sum(w => w.DestructionLevel);

            bool hasAnonymousImpactUnit = unitRepository.Models.Any(u => u.GetType().Name == nameof(AnonymousImpactUnit));
            if (hasAnonymousImpactUnit)
            {
                totalAmount += totalAmount * 0.30; 
            }
            bool hasNuclearWeapon = weaponRepository.Models.Any(w => w.GetType().Name == nameof(NuclearWeapon));
            if (hasNuclearWeapon)
            {
                totalAmount += totalAmount * 0.45;
            }

            return Math.Round(totalAmount, 3);
        }
    }
}
