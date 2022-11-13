using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<double, int> collectionOfNumbers = new Dictionary<double, int>();

        double[] numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        for (int index = 0; index < numbers.Length; index++)
        {
            double currentNumber = numbers[index];

            if (!collectionOfNumbers.ContainsKey(currentNumber))
            {
                collectionOfNumbers.Add(currentNumber, 0);
            }
            collectionOfNumbers[currentNumber]++;

        }
        PrintKeyValue(collectionOfNumbers);

    }

    private static void PrintKeyValue(Dictionary<double, int> collectionOfNumbers)
    {
        foreach (KeyValuePair<double, int> key in collectionOfNumbers)
        {
            Console.WriteLine($"{key.Key} - {key.Value} times");
        }
    }
}

