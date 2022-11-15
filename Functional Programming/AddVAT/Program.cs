using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Func<double, double> selector = x => x * 1.2;

        List<double> prices = Console.ReadLine()
            .Split(", ")
            .Select(double.Parse)
            .Select(selector)
            .ToList();

        PrintPrice(prices);

    }

    private static void PrintPrice(List<double> prices)
    {
        foreach (double price in prices)
        {
            Console.WriteLine($"{price:f2}");
        }
    }
}