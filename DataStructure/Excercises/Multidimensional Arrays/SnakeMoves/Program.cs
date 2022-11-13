using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int[] dimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int rows = dimensions[0];
        int cols = dimensions[1];

        char[,] matrix = new char[rows, cols];

        string snake = Console.ReadLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                    matrix[row, col] = snake[col];
            }
        }
    }
}
