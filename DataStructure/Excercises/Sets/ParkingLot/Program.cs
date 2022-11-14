using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> carNumbers = new HashSet<string>();
        CardNumberController(carNumbers);
    }
    private static void CardNumberController(HashSet<string> carNumbers)
    {
        while (true)
        {
            string[] input = ReadInput();
            string direction = input[0];
            if (direction == "END")
            {
                break;
            }
            string carNumber = input[1];
            ChooseDirection(carNumbers, direction, carNumber);
        }
        if (ValidateCount(carNumbers))
        {
            PrintCardNumbers(carNumbers);
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }

    private static bool ValidateCount(HashSet<string> carNumbers) => carNumbers.Any();
    private static void PrintCardNumbers(HashSet<string> carNumbers)
    {
        foreach (string carNumber in carNumbers)
        {
            Console.WriteLine(carNumber);
        }
    }

    private static void ChooseDirection(HashSet<string> carNumbers, string direction, string carNumber)
    {
        switch (direction)
        {
            case "IN":
                CheckIN(carNumbers, carNumber);
                break;
            case "OUT":
                CheckOUT(carNumbers, carNumber);
                break;

        }
    }

    private static void CheckOUT(HashSet<string> carNumbers, string carNumber) => carNumbers.Remove(carNumber);
    private static void CheckIN(HashSet<string> carNumbers, string carNumber) => carNumbers.Add(carNumber);    
    private static string[] ReadInput() => Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
}
