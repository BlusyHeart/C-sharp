using System;
using System.Linq;
using System.Collections.Generic;

class Program
{   
    static void Main()
    {
        Func<string, bool> startsWithUpperCase = word => char.IsUpper(word[0]);
       
        List<string> text = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(startsWithUpperCase)
            .ToList();

        Console.WriteLine(String.Join(Environment.NewLine, text));
    }
}
