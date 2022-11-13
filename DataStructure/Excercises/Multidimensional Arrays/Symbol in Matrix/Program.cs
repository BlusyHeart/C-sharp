using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char[,] matrix = CreateMatrix();
        FillMatrix(matrix);
        char symbol = char.Parse(Console.ReadLine());

        string result = FindSymbol(matrix, symbol);
        PrintResult(symbol, result);

    }

    private static void PrintResult(char symbol, string result)
    {
        if (result == null)
        {
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
        else
        {
            Console.WriteLine(result);
        }
    }

    private static string FindSymbol(char[,] matrix, char symbol)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                char currentSymbol = matrix[rows, columns];
                if (symbol == currentSymbol)
                {
                    return $"({rows}, {columns})";

                }
            }
        }
        return null;
    }

    private static char[,] CreateMatrix()
    {
        int matrixDimensions = int.Parse(Console.ReadLine());
        int rows = matrixDimensions;
        int cols = rows;

        char[,] matrix = new char[rows, cols];

        return matrix;
    }

    private static void FillMatrix(char[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            char[] input = Console.ReadLine()
            .ToCharArray();

            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                matrix[rows, columns] = input[columns];
            }
        }

        return matrix;
    }
}
