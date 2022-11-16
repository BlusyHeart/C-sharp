using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Func<int, int, bool> isDivisible = (x, y) => x % y == 0;
        Action<int[]> printer = numbers => Console.WriteLine(String.Join(" ", numbers));

        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Reverse()
            .ToList();

        int targetNumber = int.Parse(Console.ReadLine());

        int[] filteredNumbers = numbers.Where(x => !isDivisible(x, targetNumber)).ToArray();
        printer(filteredNumbers);
    }
}
