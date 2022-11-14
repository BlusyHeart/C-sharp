using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // read length of Sets

        int[] setsLength = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int firstSetLength = setsLength[0];
        int secondSetLength = setsLength[1];

        // initialize two HashSets
        HashSet<int> set = new HashSet<int>();
        HashSet<int> first = new HashSet<int>();
        HashSet<int> second = new HashSet<int>();

        // fill firstSet

        first = FillSet(firstSetLength, first);
        second = FillSet(secondSetLength, second);

        // FindUniqueElements and modifie the first set to contain only them

        first.IntersectWith(second);

        // Print elements in first set

        Console.WriteLine(String.Join(" ", first));
    }

    private static HashSet<int> FillSet(int firstSetLength, HashSet<int> set)
    {
        for (int index = 0; index < firstSetLength; index++)
        {
            int currentElement = int.Parse(Console.ReadLine());
            set.Add(currentElement);
        }
        return set;
    }
}
