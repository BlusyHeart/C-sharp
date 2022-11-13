
namespace ConsoleApp1
{
    public class Matrix
    {
        private static int[,] CreateMatrix()
        {
            int matrixDimensions = int.Parse(Console.ReadLine());
            int rows = matrixDimensions;
            int cols = rows;

            int[,] matrix = new int[rows, cols];

            return matrix;
        }

        private static int Sum(int[,] matrix)
        {
            int sum = 0;
            foreach (int number in matrix)
            {
                sum += number;
            }

            return sum;
        }


        private static int[,] FillMatrix(int[,] matrix)
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

        private static int FindMaxSubMatrixSquareSum(int[,] matrix, int sum, int maxSubMatrixSum, int[,] subMatrix)
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

    }
}
