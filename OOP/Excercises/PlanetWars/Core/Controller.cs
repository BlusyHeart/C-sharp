using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private readonly PlanetRepository planets;
        

        public Controller()
        {
            planets = new PlanetRepository();
        }

        public string AddUnit(string unitTypeName, string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }            
            else if (planet.Army.Any(u => u.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName, planetName));
            }
            else
            {
                IMilitaryUnit unit;
                if (unitTypeName == nameof(StormTroopers))
                {
                    unit = new StormTroopers();
                }
                else if (unitTypeName == nameof(SpaceForces))
                {
                    unit = new SpaceForces();
                }
                else if (unitTypeName == nameof(AnonymousImpactUnit))
                {
                    unit = new AnonymousImpactUnit();
                }
                else
                {
                    throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
                }
                planet.Spend(unit.Cost);
                planet.AddUnit(unit);
            }
            return string.Format(OutputMessages.UnitAdded, unitTypeName, planetName);
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }
            else if (planet.Weapons.Any(u => u.GetType().Name == weaponTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName, planetName));
            }
            else
            {
                IWeapon weapon;
                if (weaponTypeName == nameof(BioChemicalWeapon))
                {
                    weapon = new BioChemicalWeapon(destructionLevel);
                }
                else if (weaponTypeName == nameof(NuclearWeapon))
                {
                    weapon = new NuclearWeapon(destructionLevel);
                }
                else if (weaponTypeName == nameof(SpaceMissiles))
                {
                    weapon = new SpaceMissiles(destructionLevel);
                }
                else
                {
                    throw new InvalidOperationException(string.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
                }
                planet.Spend(weapon.Price);
                planet.AddWeapon(weapon);
            }
            return string.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
        }

        public string CreatePlanet(string name, double budget)
        {
            IPlanet planet = planets.FindByName(name);
            if (planet != null)
            {
                return string.Format(OutputMessages.ExistingPlanet, name);
            }
           
            planet = new Planet(name, budget);
            planets.AddItem(planet);
            return string.Format(OutputMessages.NewPlanet, name);
        }

        public string ForcesReport()
        {
            StringBuilder sb = new StringBuilder();

            List<IPlanet> sortedPlanets = planets.Models.OrderByDescending(p => p.MilitaryPower)
                .ThenBy(p => p.Name).ToList();

            sb.AppendLine("***UNIVERSE PLANET MILITARY REPORT***");
            sortedPlanets.ForEach(p => sb.AppendLine(p.PlanetInfo()));

            return sb.ToString().TrimEnd();
           
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet plantX = planets.FindByName(planetOne);
            IPlanet planetY = planets.FindByName(planetTwo);
            IPlanet winner = null;
            IPlanet looser = null;

            bool hasNuclearWeapon =
                plantX.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon)
                && planetY.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon)))
                || !plantX.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon))
                && !planetY.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon)); 
                
            if (plantX.MilitaryPower == planetY.MilitaryPower)
            {
                if (hasNuclearWeapon)
                {
                    plantX.Spend(plantX.Budget - plantX.Budget * 0.50);
                    planetY.Spend(planetY.Budget - planetY.Budget * 0.50);
                    return OutputMessages.NoWinner;
                }
                else if (plantX.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon)))
                {
                    winner = plantX;
                    looser = planetY;
                   
                }
                else if (planetY.Weapons.Any(w => w.GetType().Name == nameof(NuclearWeapon)))
                {
                    winner = planetY;
                    looser = plantX;
                }                
            }
            else
            {
                if (plantX.MilitaryPower > planetY.MilitaryPower)
                {
                    winner = plantX;
                    looser = planetY;
                }
                else 
                {
                    winner = planetY;
                    looser = plantX;
                }
            }

            winner.Spend(winner.Budget - winner.Budget * 0.50);
            winner.Profit(looser.Budget - looser.Budget * 0.50);
            winner.Profit(looser.Army.Sum(u => u.Cost) + looser.Weapons.Sum(w => w.Price));
            planets.RemoveItem(looser.Name);
            return string.Format(OutputMessages.WinnigTheWar, winner.Name, looser.Name);
        }

        public string SpecializeForces(string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);
            if (planet == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (!(planet.Army.Any()))
            {
                throw new InvalidOperationException(ExceptionMessages.NoUnitsFound);
            }

            planet.Spend(1.25);
            planet.TrainArmy();
            return string.Format(OutputMessages.ForcesUpgraded, planetName);
        }
    }
}
