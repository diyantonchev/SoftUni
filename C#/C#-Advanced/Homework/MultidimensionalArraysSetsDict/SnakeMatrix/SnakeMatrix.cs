using System;
using System.Collections.Generic;

class SnakeMatrix
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int m = Int32.Parse(Console.ReadLine());

        double[,] matrix = new double[n, m];

        int count = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col <= matrix.GetLength(1); col++)
            {
                if (row % 2 == 0)
                {
                    matrix[row, col - 1] = count;
                    count++;
                }
                else
                {
                    matrix[row, (matrix.GetLength(1) - 1) - (col - 1)] = count;
                    count++;
                }
            }           
        }
        PrintMatrix(matrix);
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
}
