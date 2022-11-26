using System;
using System.Collections.Generic;
using System.Linq;

namespace StreeRacing
{
    class StartUp
    {
        static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());

            char[][] beach = new char[matrixRows][];
            FillJaggedArray(beach);

            string[] input = Console.ReadLine().Split();
            string command = input[0];

            List<int> collectionTokens = new List<int>();
            List<int> oppositeTokens = new List<int>();

            while (command != "Gong")
            {
                int tokenRow;
                int tokenCol;
                switch (command)
                {
                    case "Find":

                        tokenRow = int.Parse(input[1]);
                        tokenCol = int.Parse(input[2]);

                        if (ValidateCoordinates(beach, tokenRow, tokenCol))
                        {
                            bool isFound = Find(beach, tokenRow, tokenCol);
                            if (isFound)
                            {
                                collectionTokens.Add(1);
                            }
                        }

                        break;
                    case "Opponent":

                        tokenRow = int.Parse(input[1]);
                        tokenCol = int.Parse(input[2]);
                        string direction = input[3];

                        MoveController(beach, input, collectionTokens, oppositeTokens);
                        break;
                }

                input = Console.ReadLine().Split();
                command = input[0];

            }

            PrintBeach(beach);
            Console.WriteLine($"Collected tokens: {collectionTokens.Sum()}");
            Console.WriteLine($"Opponent's tokens: {oppositeTokens.Sum()}");

        }

        private static void PrintBeach(char[][] beach)
        {
            foreach (char[] @char in beach)
            {
                Console.WriteLine(string.Join(" ", @char));
            }
        }

        private static void MoveController(char[][] beach, string[] input, List<int> collectionTokens, List<int> oppositeTokens)
        {
            int tokenRow = int.Parse(input[1]);
            int tokenCol = int.Parse(input[2]);

            if (ValidateCoordinates(beach, tokenRow, tokenCol))
            {
                bool isFound = Find(beach, tokenRow, tokenCol);
                if (isFound)
                {
                    oppositeTokens.Add(1);
                }

                string direction = input[3];

                switch (direction)
                {
                    case "up":
                        if (tokenRow - 2 < 0)
                        {
                            Up(beach, tokenRow, tokenCol, oppositeTokens);
                        }
                        else
                        {
                            Up3Steps(beach, tokenRow, tokenCol, oppositeTokens);
                        }
                        break;
                    case "down":
                        if (tokenRow + 3 > beach.GetLength(0))
                        {
                            Down(beach, tokenRow, tokenCol, oppositeTokens);
                        }
                        else
                        {
                            Down3Steps(beach, tokenRow, tokenCol, oppositeTokens);
                        }
                        break;
                    case "left":
                        if (tokenCol - 3 < 0)
                        {
                            Left(beach, oppositeTokens, tokenRow, tokenCol);
                        }
                        else
                        {
                            Left3Steps(beach, oppositeTokens, tokenRow, tokenCol);
                        }
                        break;
                    case "right":
                        if (tokenCol + 3 > beach[tokenRow].Length)
                        {
                            Right(beach, oppositeTokens, tokenRow, tokenCol);
                        }
                        else
                        {
                            Right3Steps(beach, oppositeTokens, tokenRow, tokenCol);
                        }
                        break;
                }

            }
        }

        private static void Right3Steps(char[][] beach, List<int> oppositeTokens, int tokenRow, int tokenCol)
        {
            int rowEnd = tokenRow + 1;
            for (int row = 0; row < rowEnd; row++)
            {
                for (int col = tokenCol; col <= tokenCol + 3; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void Right(char[][] beach, List<int> oppositeTokens, int tokenRow, int tokenCol)
        {
            int rowEnd = tokenRow + 1;
            for (int row = 0; row < rowEnd; row++)
            {
                for (int col = tokenCol; col < beach[tokenRow].Length; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void Left3Steps(char[][] beach, List<int> oppositeTokens, int tokenRow, int tokenCol)
        {
            int rowEnd = tokenRow + 1;
            for (int row = 0; row < rowEnd; row++)
            {
                for (int col = tokenCol - 3; col >= 0; col--)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void Left(char[][] beach, List<int> oppositeTokens, int tokenRow, int tokenCol)
        {
            int rowEnd = tokenRow + 1;
            for (int row = 0; row < rowEnd; row++)
            {
                for (int col = tokenCol - 1; col >= 0; col--)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static bool ValidateCoordinates(char[][] beach, int tokenRow, int tokenCol)
        {
            return tokenRow >= 0 && tokenRow < beach.GetLength(0)
                && tokenCol >= 0 && tokenCol < beach[tokenRow].Length;
        }

        private static bool Find(char[][] beach, int tokenRow, int tokenCol)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    if (tokenRow == row && tokenCol == col)
                    {
                        if (beach[row][col] == 'T')
                        {
                            beach[row][col] = '-';
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static void FillJaggedArray(char[][] beach)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split();
                char[] beachRow = line.Select(x => char.Parse(x)).ToArray();

                beach[row] = beachRow;
            }
        }

        private static void Up3Steps(char[][] beach, int tokenRow, int tokenCol, List<int> oppositeTokens)
        {
            int colEnd = tokenCol + 1;
            for (int row = tokenRow; row >= tokenRow - 3; row--)
            {
                for (int col = tokenCol; col < colEnd; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void MatchToken(char[][] beach, List<int> oppositeTokens, int row, int col)
        {
            if (beach[row][col] == 'T')
            {
                beach[row][col] = '-';
                oppositeTokens.Add(1);
            }
        }

        private static void Down(char[][] beach, int tokenRow, int tokenCol, List<int> oppositeTokens)
        {
            int colEnd = tokenCol + 1;
            int rowEnd = beach.GetLength(0);

            for (int row = tokenRow; row < rowEnd; row++)
            {
                for (int col = tokenCol; col < colEnd; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void Up(char[][] beach, int tokenRow, int tokenCol, List<int> oppositeTokens)
        {
            int colEnd = tokenCol + 1;

            for (int row = tokenRow; row >= 0; row--)
            {
                for (int col = tokenCol; col < colEnd; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }

        private static void Down3Steps(char[][] beach, int tokenRow, int tokenCol, List<int> oppositeTokens)
        {
            int colEnd = tokenCol + 1;
            int rowEnd = tokenRow + 3;

            for (int row = tokenRow; row <= rowEnd; row++)
            {
                for (int col = tokenCol; col < colEnd; col++)
                {
                    MatchToken(beach, oppositeTokens, row, col);
                }
            }
        }
    }
}


