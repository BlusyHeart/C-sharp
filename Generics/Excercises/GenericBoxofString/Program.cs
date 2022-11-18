using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxofString
{
    public class StartUp
    {
        public static void Main()
        {
            Box<string> box = new Box<string>();
            int numberOfInputs = int.Parse(Console.ReadLine());
           
            for (int index = 0; index < numberOfInputs; index++)
            {
                string input = Console.ReadLine();               
                box.Add(input);               
            }

            int[] indexs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexs[0];
            int secondIndex= indexs[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }

}
