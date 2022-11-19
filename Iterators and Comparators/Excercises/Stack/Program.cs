using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main()
        {
            MyStack<int> stack = new MyStack<int>();
            while (true)
            {
                char[] delimeters = new char[] { ' ', ',' };

                string[] input = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (command == "Push")
                {
                    int[] elements = input.Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (int element in elements)
                    {
                        stack.Push(element);
                    }
                }
            }

            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
