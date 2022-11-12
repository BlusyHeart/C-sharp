using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const int pushAction = 1;
        const int popAction = 2;
        const int printMax = 3;
        const int printMin = 4;

        int numberOfQueries = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < numberOfQueries; i++)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int command = numbers[0];

            switch (command)
            {
                case pushAction:
                    stack.Push(numbers[1]);
                    break;
                case popAction:
                case printMax:
                case printMin:
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (command == printMax)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        else if (command == printMin)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }

                    break;
            }

        }

        Console.WriteLine(String.Join(", ", stack));
    }
}