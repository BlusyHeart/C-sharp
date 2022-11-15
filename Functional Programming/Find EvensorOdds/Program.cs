using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Predicate<int> isEven = number => number % 2 == 0;

        int[] rangeOfNumbersData = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        List<int> numbers = new List<int>();

        int startIndex = rangeOfNumbersData[0];
        int end = rangeOfNumbersData[1];
        string command = Console.ReadLine();
        AddRange(numbers, startIndex, end);

        if (command == "even")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(number => isEven(number))));
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers.Where(number => !isEven(number))));
        }
    }

    private static void AddRange(List<int> numbers, int startIndex, int end)
    {
        for (int i = startIndex; i <= end; i++)
        {
            numbers.Add(i);
        }
    }
}



