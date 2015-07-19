using System;

namespace Parachute
{
    using System.Collections.Generic;

    class Parachute
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            var matrix = new List<char[]>();
            while (inputLine != "END")
            {
                matrix.Add(inputLine.ToCharArray());
                inputLine = Console.ReadLine();
            }

            int[] coordinates = FindTheJumper(matrix);

            int index = coordinates[1];
            int startRow = coordinates[0];

            for (int row = startRow + 1; row < matrix.Count; row++)
            {
                int movementPositions = CalculateTheWind(matrix[row]);
                index += movementPositions;
                
                if (CheckForCollision(matrix[row][index]))
                {
                    Report(matrix[row][index]);
                    Console.WriteLine("{0} {1}", row, index);
                    break;
                }
            }
        }

        private static int[] FindTheJumper(List<char[]> matrix)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'o')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }
            return coordinates;
        }

        private static void Report(char currentSymbol)
        {
            switch (currentSymbol)
            {
                case '_':
                    Console.WriteLine("Landed on the ground like a boss!");
                    break;
                    case '~':
                    Console.WriteLine("Drowned in the water like a cat!");
                    break;
                    case '/':
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    break;
                    case '\\':
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    break;
                case '|':
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    break;
            }
        }

        private static bool CheckForCollision(char currentSymbol)
        {
            return currentSymbol != '-' && currentSymbol != '<' && currentSymbol != '>';
        }

        private static int CalculateTheWind(char[] row)
        {
            int leftDirectionCounter = 0;
            int rightDirectionCounter = 0;

            foreach (char direction in row)
            {
                switch (direction)
                {
                    case '<':
                        leftDirectionCounter++;
                        break;
                    case '>':
                        rightDirectionCounter++;
                        break;
                }
            }
            return rightDirectionCounter - leftDirectionCounter;
        }
    }
}