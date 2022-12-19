using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private readonly List<IMilitaryUnit> militaryUnits;

        public UnitRepository()
        {
            militaryUnits = new List<IMilitaryUnit>();
        }

        public IReadOnlyCollection<IMilitaryUnit> Models => militaryUnits.AsReadOnly();

        public void AddItem(IMilitaryUnit unit) => militaryUnits.Add(unit);


        public IMilitaryUnit FindByName(string unitTypeName) => militaryUnits.FirstOrDefault(w => w.GetType().Name == unitTypeName);


        public bool RemoveItem(string unitTypeName) => militaryUnits.Remove(militaryUnits.Find(w => w.GetType().Name == unitTypeName));

    }
}
