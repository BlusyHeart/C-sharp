using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[,] matrix = CreateMatrix();
        FillMatrix(matrix);

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] inputArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            // if returns true we are good
            if (InputValidation(matrix, inputArguments))
            {
                Swap(matrix, inputArguments);

                PrintMatrix(matrix);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    private static void Swap(string[,] matrix, string[] inputArguments)
    {
        int firstCoordinate = int.Parse(inputArguments[1]);
        int secondCoordinate = int.Parse(inputArguments[2]);
        int thirdCoordinate = int.Parse(inputArguments[3]);
        int fourthCoordinate = int.Parse(inputArguments[4]);

        string temp = matrix[firstCoordinate, secondCoordinate];
        matrix[firstCoordinate, secondCoordinate] = matrix[thirdCoordinate, fourthCoordinate];
        matrix[thirdCoordinate, fourthCoordinate] = temp;

    }

    private static bool InputValidation(string[,] matrix, string[] inputArguments)
    {
        bool isValidInput = false;
        if (inputArguments.Contains("swap") && inputArguments.Length == 5)
        {
            int firstCoordinate = int.Parse(inputArguments[1]);
            int secondCoordinate = int.Parse(inputArguments[2]);
            int thirdCoordinate = int.Parse(inputArguments[3]);
            int fourthCoordinate = int.Parse(inputArguments[4]);

            isValidInput =
            firstCoordinate >= 0
         && firstCoordinate < matrix.GetLength(0)
         && secondCoordinate >= 0
         && secondCoordinate < matrix.GetLength(1)
         && thirdCoordinate >= 0
         && thirdCoordinate < matrix.GetLength(0)
         && fourthCoordinate >= 0
         && fourthCoordinate < matrix.GetLength(1);

        }
        else
        {
            return isValidInput;
        }

        return isValidInput;
    }

    private static string[,] CreateMatrix()
    {
        int[] matrixDimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int rows = matrixDimensions[0];
        int cols = matrixDimensions[1];

        string[,] matrix = new string[rows, cols];

        return matrix;
    }

    private static string[,] FillMatrix(string[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                matrix[rows, columns] = input[columns];
            }
        }

        return matrix;
    }
}
