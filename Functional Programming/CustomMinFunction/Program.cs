using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {       
        int[] numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> minNumber = number =>
        {
            int minValue = int.MaxValue;
            foreach (int item in numbers)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }
            return minValue;
        };

        Console.WriteLine(minNumber(numbers));        
    }
}
