using Raiding.Core;
using Raiding.Factories;
using Raiding.IO;
using Raiding.IO.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace StreeRacing
{
    class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            RaidFactory raidFactory = new RaidFactory(reader, writer);
            List<BaseHero> raid = raidFactory.CreateRaid();

            Engine engine = new Engine(reader, writer, raid);
            engine.Start();
        }
    }
}


