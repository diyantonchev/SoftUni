using System;
using System.Collections.Generic;
using System.Linq;

internal class FireTheArrows
{
    private static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        var matrix = new List<char[]>();
        var arrows = new List<char>() { 'v', '^', '>', '<' };
        for (int i = 0; i < linesCount; i++)
        {
            matrix.Add(Console.ReadLine().ToCharArray());
        }

        bool hasArrowsForMove = true;
        while (hasArrowsForMove)
        {
            hasArrowsForMove = false;
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int nextRow = 0;
                    int nextCol = 0;
                    char nextSymbol;
                    bool hasMoved = false;
                    switch (matrix[row][col])
                    {
                        case 'v':
                            nextRow = Math.Min(row + 1, matrix.Count - 1);
                            nextSymbol = matrix[nextRow][col];
                            if (arrows.All(symbol => symbol != nextSymbol))
                            {
                                matrix[nextRow][col] = 'v';
                                matrix[row][col] = 'o';
                                hasMoved = true;
                            }
                            break;
                        case '^':
                            nextRow = Math.Max(row - 1, 0);
                            nextSymbol = matrix[nextRow][col];
                            if (arrows.All(symbol => symbol != nextSymbol))
                            {
                                matrix[nextRow][col] = '^';
                                matrix[row][col] = 'o';
                                hasMoved = true;
                            }
                            break;
                        case '>':
                            nextCol = Math.Min(col + 1, matrix[row].Length - 1);
                            nextSymbol = matrix[row][nextCol];
                            if (arrows.All(symbol => symbol != nextSymbol))
                            {
                                matrix[row][nextCol] = '>';
                                matrix[row][col] = 'o';
                                hasMoved = true;
                            }
                            break;
                        case '<':
                            nextCol = Math.Max(col - 1, 0);
                            nextSymbol = matrix[row][nextCol];
                            if (arrows.All(symbol => symbol != nextSymbol))
                            {
                                matrix[row][nextCol] = '<';
                                matrix[row][col] = 'o';
                                hasMoved = true;
                            }
                            break;
                    }
                    if (hasMoved)
                    {
                        hasArrowsForMove = true;
                    }
                }
            }
        }
        PrintMatrix(matrix);
    }

    public static void PrintMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(matrix[row][col]);
            }
            Console.WriteLine();
        }
    }
}