using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = CreateMatrix();
        FillMatrix(matrix);
        int maxSubMatrixSum = int.MinValue;
        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;
        FindMaxSubMatrix(matrix, maxSubMatrixSum, startIndex, endIndex, sum);

    }

    private static void FindMaxSubMatrix(int[,] matrix, int maxSubMatrixSum, int startIndex, int endIndex, int sum)
    {
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = SumSubmatrix(matrix, maxSubMatrixSum, row, col);
                if (sum > maxSubMatrixSum)
                {
                    maxSubMatrixSum = sum;
                    startIndex = row;
                    endIndex = col;
                }

            }
        }
        Console.WriteLine($"Sum = {maxSubMatrixSum}");
        PrintSubMatrix(matrix, startIndex, endIndex);
    }

    private static int SumSubmatrix(int[,] matrix, int maxSubMatrixSum, int row, int col)
    {
        int sum = matrix[row, col]
                                     + matrix[row, col + 1]
                                     + matrix[row, col + 2]
                                     + matrix[row + 1, col]
                                     + matrix[row + 1, col + 1]
                                     + matrix[row + 1, col + 2]
                                     + matrix[row + 2, col]
                                     + matrix[row + 2, col + 1]
                                     + matrix[row + 2, col + 2];



        return sum;
    }

    private static void PrintSubMatrix(int[,] matrix, int startIndex, int endIndex)
    {
        int endRow = startIndex + 3;
        int endCol = endIndex + 3;

        for (int row = startIndex; row < endRow; row++)
        {
            for (int col = endIndex; col < endCol; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    private static int[,] CreateMatrix()
    {
        int[] matrixDimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int rows = matrixDimensions[0];
        int cols = matrixDimensions[1];

        int[,] matrix = new int[rows, cols];

        return matrix;
    }

    private static int[,] FillMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                matrix[rows, columns] = input[columns];
            }
        }

        return matrix;
    }

}
