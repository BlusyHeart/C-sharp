using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Action<string[]> printer = names
            => Console.WriteLine(string.Join(Environment.NewLine, names));

        string[] input = Console.ReadLine().Split();

        printer(input);
        
    }

}