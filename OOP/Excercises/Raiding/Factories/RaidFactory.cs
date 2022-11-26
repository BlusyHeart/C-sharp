using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factories
{
    public class RaidFactory : IRaidFactory
    {        
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly List<BaseHero> raid;
        private readonly HeroFactory heroFactory;

        public RaidFactory()
        {
            this.heroFactory = new HeroFactory();
            this.raid = new List<BaseHero>();
        }

        public RaidFactory(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        
        public List<BaseHero> CreateRaid()
        {
            int numberOfHeroesToCreate = int.Parse(reader.ReadLine());

            while (raid.Count < numberOfHeroesToCreate)
            {
                string name = reader.ReadLine();
                string heroType = reader.ReadLine();

                raid.Add(heroFactory.CreateHero(name, heroType));
            }
            return raid;
        }
    }
}
