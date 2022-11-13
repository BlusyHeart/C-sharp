using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int[][] jaggedArray = CreateJaggedArray();
       
        JaggedArrayManipulation(jaggedArray);

    }

    private static void JaggedArrayManipulation(int[][] jaggeArray)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] commandArgs = input.Split();
            string command = commandArgs[0];
            int firstCordinate = int.Parse(commandArgs[1]);
            int secondCordinate = int.Parse(commandArgs[2]);
            int number = int.Parse(commandArgs[3]);

            bool isInvalid = firstCordinate < 0
                      || firstCordinate > jaggeArray.Length - 1
                      || secondCordinate < 0
                      || secondCordinate > jaggeArray[firstCordinate].Length - 1;

            if (isInvalid)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }
            else
            {
                switch (command)
                {
                    case "Add":
                        Add(jaggeArray, firstCordinate, secondCordinate, number);
                        break;

                    case "Subtract":
                        Subtract(jaggeArray, firstCordinate, secondCordinate, number);
                        break;
                }
            }
        }

        PrintJaggedArray(jaggeArray);
    }

    private static void PrintJaggedArray(int[][] jaggeArray)
    {
        for (int row = 0; row < jaggeArray.Length; row++)
        {
            Console.WriteLine(string.Join(" ", jaggeArray[row]));
        }
    }

    private static void Subtract(int[][] jaggeArray, int firstCordinate, int secondCordinate, int number)
    {
        for (int row = 0; row < jaggeArray.Length; row++)
        {
            for (int columns = 0; columns < jaggeArray[row].Length; columns++)
            {
                int currentIndex = jaggeArray[row][columns];
                int targetIndex = jaggeArray[firstCordinate][secondCordinate];
                if (currentIndex == targetIndex)
                {
                    jaggeArray[firstCordinate][secondCordinate] -= number;
                    return;
                }
            }
        }
    }

    private static void Add(int[][] jaggeArray, int firstCordinate, int secondCordinate, int number)
    {
              
            for (int row = 0; row < jaggeArray.Length; row++)
            {
                for (int columns = 0; columns < jaggeArray[row].Length; columns++)
                {
                int currentIndex = jaggeArray[row][columns];
                int targetIndex = jaggeArray[firstCordinate][secondCordinate];
                if (currentIndex == targetIndex)
                {
                    jaggeArray[firstCordinate][secondCordinate] += number;
                    return;
                }
            }
            }
        
    }

    private static int[][] CreateJaggedArray()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];
        
        for (int row = 0; row < jaggedArray.Length; row++)
        {
            jaggedArray[row] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
        return jaggedArray;
    }
}