using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // read countNumebrs

        int countNumbers = int.Parse(Console.ReadLine());

        // initialize dictionary

        Dictionary<int, int> numbers = new Dictionary<int, int>();

        // read numbers

        ReadInput(countNumbers, numbers);

        // check every numberCounter for even times
        CheckEven(numbers);

    }

    private static void CheckEven(Dictionary<int, int> numbers)
    {
        foreach (KeyValuePair<int, int> number in numbers)
        {
            // if counter even print number
            if (number.Value % 2 == 0)
            {
                Console.WriteLine(number.Key);
            }

        }
    }

    private static void ReadInput(int countNumbers, Dictionary<int, int> numbers)
    {
        for (int i = 0; i < countNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());

            // check if the dictionary contains this number

            AddKeyValue(numbers, number);

        }
    }

    private static void AddKeyValue(Dictionary<int, int> numbers, int number)
    {
        if (!numbers.ContainsKey(number))
        {
            numbers.Add(number, 0);
        }

        // add counter to the key
        numbers[number] += 1;
    }
}
