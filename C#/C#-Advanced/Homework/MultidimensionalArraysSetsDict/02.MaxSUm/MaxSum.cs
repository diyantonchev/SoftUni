using System;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        var matrix = ReadMatrix();       

        Console.WriteLine();
        PrintMatrix(matrix);
        Console.WriteLine();

        double maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            double sum = 0;
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                       matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                       matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
                sum = 0;
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);

        for (var row = bestRow; row <= bestRow + 2; row++)
        {
            for (var col = bestCol; col <= bestCol + 2; col++)
            {
                Console.Write("{0, -4}",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static double[,] ReadMatrix()
    {
        string[] parameters = Console.ReadLine().Split().ToArray();
        int n = int.Parse(parameters[0]);
        int m = int.Parse(parameters[1]);

        var matrix = new double[n, m];
        var elements = new double[m];

        for (int row = 0; row < n; row++)
        {
            elements = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = elements[col];
            }
        }

        return matrix;
    }
}
