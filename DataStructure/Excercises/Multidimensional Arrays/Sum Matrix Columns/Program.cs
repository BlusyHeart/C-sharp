using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = CreateMatrix();
        matrix = FillMatrix(matrix);

        PrintSumColumn(matrix);

    }

    private static void PrintSumColumn(int[,] matrix)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                sum += matrix[rows, columns];

            }
            Console.WriteLine(sum);
        }
    }

    private static int[,] FillMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int[] input = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                matrix[rows, columns] = input[columns];
            }
        }

        return matrix;
    }

    private static int[,] CreateMatrix()
    {
        int[] matrixDimensions = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

        int rows = matrixDimensions[0];
        int columns = matrixDimensions[1];
        int[,] matrix = new int[rows, columns];

        return matrix;
    }
}