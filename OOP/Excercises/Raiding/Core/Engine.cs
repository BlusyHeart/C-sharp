using Raiding.IO.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly List<BaseHero> raid;

        public Engine(IReader reader, IWriter writer, List<BaseHero> raid)
        {
            this.reader = reader;
            this.writer = writer;
            this.raid = raid;
        }
      
        public void Start()
        {
            int bossPower = int.Parse(reader.ReadLine());

            int raidTotalPower = raid.Sum(x => x.Power);

            if (raidTotalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
