using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Action<string> printer = name => Console.WriteLine($"Sir {name}");

        string[] names = Console.ReadLine().Split();
        Print(names, printer);
    }

    static void Print(string[] names, Action<string> printer)
    {
        foreach (string name in names)
        {
            printer(name);
        }
    }
   
}
