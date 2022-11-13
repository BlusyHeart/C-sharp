using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
        int numberOfInputs = int.Parse(Console.ReadLine());
        AddStudentGrade(studentGrades, numberOfInputs);
        PrintKeyValue(studentGrades);

    }

    private static void AddStudentGrade(Dictionary<string, List<double>> studentGrades, int numberOfInputs)
    {
        for (int index = 0; index < numberOfInputs; index++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];

            if (!studentGrades.ContainsKey(name))
            {
                studentGrades.Add(name, new List<double>());
            }

            double grade = double.Parse(input[1]);
            studentGrades[name].Add(grade);

        }
    }

    private static void PrintKeyValue(Dictionary<string, List<double>> collectionOfNumbers)
    {
        foreach (KeyValuePair<string, List<double>> key in collectionOfNumbers)
        {
            Console.WriteLine($"{key.Key} -> {string.Join(" ", key.Value)} (avg: {key.Value.Average()})");
        }
    }
}

