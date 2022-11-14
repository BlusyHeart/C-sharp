using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> uniqueUsernames = new Dictionary<string, int>();
        AddUserNames(uniqueUsernames);
        PrintUserNames(uniqueUsernames);
    }

    private static void PrintUserNames(Dictionary<string, int> uniqueUsernames)
    {
        foreach (KeyValuePair<string, int> key in uniqueUsernames)
        {
            Console.WriteLine(key.Key);
        }
    }

    private static void AddUserNames(Dictionary<string, int> uniqueUsernames)
    {
        int numberOfUsers = int.Parse(Console.ReadLine());

        for (int index = 0; index < numberOfUsers; index++)
        {
            string userName = Console.ReadLine();
            if (!uniqueUsernames.ContainsKey(userName))
            {
                uniqueUsernames.Add(userName, index);
            }
        }
    }
}
