using CommandPattern.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.IO.Models
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string command)
        {
            Console.Write(command);
        }

        public void WriteLine(string command)
        {
           Console.WriteLine(command);
        }
    }
}
