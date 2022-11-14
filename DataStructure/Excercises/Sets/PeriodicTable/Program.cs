using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // read numberOfElements

        int numberOfElements = int.Parse(Console.ReadLine());

        // initialize sortedHashSet

        SortedSet<string> periodicTable = new SortedSet<string>();

        // fill HashSet with chemical compounds

        FillSortedSet(numberOfElements, periodicTable);

        // print periodic table

        Console.WriteLine(string.Join(" ", periodicTable));

    }

    private static void FillSortedSet(int numberOfElements, SortedSet<string> periodicTable)
    {        
        ReadElements(numberOfElements, periodicTable);
    }

    private static void ReadElements(int numberOfElements, SortedSet<string> periodicTable)
    {
        for (int i = 0; i < numberOfElements; i++)
        {
            // Split input into single elements
            string[] chemicalElements = Console.ReadLine().Split();

            // add them to HashSet
            AddElement(periodicTable, chemicalElements);
        }
    }

    private static void AddElement(SortedSet<string> periodicTable, string[] chemicalElements)
    {
        foreach (string element in chemicalElements)
        {
            periodicTable.Add(element);
        }
    }
}
