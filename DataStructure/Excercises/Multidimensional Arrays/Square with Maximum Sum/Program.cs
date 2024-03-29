﻿using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = CreateMatrix();
<<<<<<< HEAD
        matrix = FillMatrix(matrix);

=======
        FillMatrix(matrix);
       
>>>>>>> 11e3444112efe25466a0b256fe01d6b35b3b14d9
        int sum = 0;
        int maxSubMatrixSum = int.MinValue;
        int[,] subMatrix = new int[2, 2];
        int maxSqareMatrixSum = FindMaxSquareSum(matrix, sum, maxSubMatrixSum, subMatrix);

        for (int rows = 0; rows < subMatrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < subMatrix.GetLength(1); cols++)
            {
                int currentNumber = subMatrix[rows, cols];
                Console.Write($"{currentNumber} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(maxSubMatrixSum);

    }

    private static int FindMaxSquareSum(int[,] matrix, int sum, int maxSubMatrixSum, int[,] subMatrix)
    {
        for (int rows = matrix.GetLength(0) - 1; rows > 0; rows--)
        {
            for (int columns = matrix.GetLength(1) - 1; columns > 0; columns--)
            {
                sum += matrix[rows, columns]
                    + matrix[rows, columns - 1]
                    + matrix[rows - 1, columns - 1]
                    + matrix[rows - 1, columns];

                if (sum >= maxSubMatrixSum)
                {
                    maxSubMatrixSum = sum;
                    subMatrix[0, 0] = matrix[rows - 1, columns - 1];
                    subMatrix[0, 1] = matrix[rows - 1, columns];
                    subMatrix[1, 0] = matrix[rows, columns - 1];
                    subMatrix[1, 1] = matrix[rows, columns];

                }
                sum = 0;
            }

        }
        return maxSubMatrixSum;
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

    private static void FillMatrix(int[,] matrix)
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
}
