using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      
        List<int> numbers = Console.ReadLine()
            .Split(", ",StringSplitOptions.RemoveEmptyEntries)
            .Select(MyParse)
            .ToList();

        Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Sum());
    }    

    // 1579
    static int MyParse(string numberToString)
    {
        int number = 0;
        foreach (char symbol in numberToString)
        {
            number *= 10;
            number += symbol - '0';
        }
        return number;

    }
}