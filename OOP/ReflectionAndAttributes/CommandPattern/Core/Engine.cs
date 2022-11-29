using CommandPattern.Core.Contracts;
using CommandPattern.IO.Interfaces;
using CommandPattern.IO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core
{
   
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        private readonly IReader reader;
        private readonly IWriter writer;


        public Engine()
        {
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
        }

        public Engine(ICommandInterpreter commandInterpreter)
            :this()
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();

                string result = commandInterpreter.Read(input);

                writer.WriteLine(result);

            }
        }
    }
}
