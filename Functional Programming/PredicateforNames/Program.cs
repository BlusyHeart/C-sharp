using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Func<string, int, bool> isLessOrEqual = (name, targetLength) => name.Length <= targetLength;
        Action<string[]> printer = numbers => Console.WriteLine(String.Join(Environment.NewLine, numbers));

        int targetLength = int.Parse(Console.ReadLine());
        string []names = Console.ReadLine().Split();

        string[] filteredNames = names.Where(x => isLessOrEqual(x, targetLength)).ToArray();

        printer(filteredNames);
    }
}