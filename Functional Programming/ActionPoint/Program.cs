using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        Action<string> printer = name => Console.WriteLine(name);
        Print(names, printer);

    }

    private static void Print(string[] names, Action<string> printer)
    {
        foreach (string name in names)
        {
            printer(name);
        }
    }
}