using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly List<IWeapon> weapons;

        public WeaponRepository()
        {
            weapons = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => weapons.AsReadOnly();

        public void AddItem(IWeapon weapon) => weapons.Add(weapon);

        public IWeapon FindByName(string weaponTypeName) => weapons.FirstOrDefault(w => w.GetType().Name == weaponTypeName);

        public bool RemoveItem(string weaponTypeName) => weapons.Remove(weapons.Find(w => w.GetType().Name == weaponTypeName));

    }
}
