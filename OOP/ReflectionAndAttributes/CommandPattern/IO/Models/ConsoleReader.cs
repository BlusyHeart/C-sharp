using CommandPattern.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.IO.Models
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
