using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = CreateMatrix();
        matrix = FillMatrix(matrix);
       
        Console.WriteLine(PrimaryDiagonalSum(matrix));

    }

    private static int PrimaryDiagonalSum(int[,] matrix)
    {
        int primaryDiagonalSum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {           
            for (int columns = rows; columns <= rows; columns++)
            {
                primaryDiagonalSum += matrix[rows, columns];
            }
        }
        return primaryDiagonalSum;
    }

    private static int[,] FillMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            int[] input = Console.ReadLine()
            .Split()
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
        int matrixDimensions = int.Parse(Console.ReadLine());
        int rows = matrixDimensions;
        int cols = rows;
                            
        int[,] matrix = new int[rows, cols];

        return matrix;
    }
}