using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();       
        FillHashSet(names);
        Console.WriteLine(String.Join(Environment.NewLine, names));
    }

    private static void FillHashSet(HashSet<string> set)
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfInputs; i++)
        {
            set.Add(Console.ReadLine());
        }
    }
}
