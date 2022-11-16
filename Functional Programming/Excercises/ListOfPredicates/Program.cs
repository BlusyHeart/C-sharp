using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Action<int[]> printer = numbers => Console.WriteLine(String.Join(" ", numbers));
        Func<int, int[], bool> isDivisbile = (number, dividers) =>
        {          
            foreach (int divider in dividers)
            {
                bool isDivisbile = false;
                if (number % divider == 0) 
                {
                    isDivisbile = true;                   
                }
                else
                {
                    return false;
                }
            }
            return true;
        };

        int endRange = int.Parse(Console.ReadLine());
        int[] rangeOfNumbers = Enumerable.Range(1, endRange).ToArray();

        int[] dividers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] newArray = rangeOfNumbers.Where(x => isDivisbile(x, dividers)).ToArray();
        printer(newArray);
    }
}
