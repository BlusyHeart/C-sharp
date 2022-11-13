using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string[,] matrix = CreateMatrix();
        FillMatrix(matrix);
        int countEqualSubMatrix = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                bool isEqualSquare = matrix[row, col] == matrix[row, col + 1]
                    && matrix[row, col] == matrix[row + 1, col]
                    && matrix[row, col] == matrix[row + 1, col + 1];

                if (isEqualSquare)
                {
                    countEqualSubMatrix++;
                }
            }
        }

        Console.WriteLine(countEqualSubMatrix);

    }

    private static string[,] FillMatrix(string[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            string[] input = Console.ReadLine().Split();


            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                matrix[rows, columns] = input[columns];
            }
        }

        return matrix;
    }

    private static string[,] CreateMatrix()
    {
        string[] matrixDimensions = Console.ReadLine().Split();
        int rows = int.Parse(matrixDimensions[0]);
        int cols = int.Parse(matrixDimensions[1]);

        string[,] matrix = new string[rows, cols];

        return matrix;
    }
}