using System;
using System.Linq;
using System.Collections.Generic;

class BasicStackOperations
{

    static void Main()
    {
        string[] args = Console.ReadLine().Split();

        int countElementsToPush = int.Parse(args[0]);
        int countElementsToPop = int.Parse(args[1]);
        int elementToFind = int.Parse(args[2]);

        int[] collection = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> numbers = new Stack<int>();

        PushMany(countElementsToPush, collection, numbers);
        PopMany(countElementsToPop, numbers);

        if (numbers.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }
        else
        {
            if (numbers.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }

    private static void PopMany(int countElementsToPop, Stack<int> numbers)
    {
        for (int i = 0; i < countElementsToPop; i++)
        {
                numbers.Pop();
        }
       
    }

    private static void PushMany(int countElementsToPush, int[] collection, Stack<int> numbers)
    {
        for (int index = 0; index < countElementsToPush; index++)
        {
            numbers.Push(collection[index]);

        }
    }

    
}


