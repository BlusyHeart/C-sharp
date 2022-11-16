using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Func<int, int> add = item => item += 1;
        Func<int, int> subtract = item => item - 1;
        Func<int, int> multiply = item => item * 2;
        Action<int[]> printer = numbers => Console.WriteLine(string.Join(" ", numbers));

        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        numbers = ArithmeticCalculator(add, subtract, multiply, printer, numbers);
    }

    private static int[] ArithmeticCalculator(Func<int, int> add, Func<int, int> subtract, Func<int, int> multiply, Action<int[]> printer, int[] numbers)
    {
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }
            else if (command == "add")
            {
                numbers = numbers.Select(add).ToArray();
            }
            else if (command == "subtract")
            {
                numbers = numbers.Select(subtract).ToArray();
            }
            else if (command == "multiply")
            {
                numbers = numbers.Select(multiply).ToArray();
            }
            else if (command == "print")
            {
                printer(numbers);
            }
        }

        return numbers;
    }
}