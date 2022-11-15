using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(String.Join(", ", numbers));
    }
    
}