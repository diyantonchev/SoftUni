using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter matrix height: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter matrix width: ");
            //int m = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[n, m];

            //Console.WriteLine("Insert matrix elements:");
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}

            int[,] matrix = 
            {
                {1, 3, 4, 6, 9, 5, 8, 0},
                {3, 6, 8, 2, 9, 1, 0, 1},
                {6, 2, 0, 3, 7, 5, 4, 2},
                {9, 0, 5, 3, 2, 6, 7, 3},
                {3, 4, 6, 4, 8, 3, 1, 4},
                {4, 1, 7, 3, 9, 6, 8, 5},
                {2, 9, 1, 2, 0, 5, 7, 6},
                {1, 4, 5, 6, 9, 3, 2, 7},
                {1, 2, 3, 4, 5, 6, 7, 8},
                {7, 6, 5, 4, 3, 2, 1, 9},
                {0, 9, 8, 7, 6, 5, 4, 0}
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]); ;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine("The max platform is:");
            Console.WriteLine("{0}{1}{2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
            Console.WriteLine("{0}{1}{2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
            Console.WriteLine("{0}{1}{2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
            Console.WriteLine("The max sum is: {0}", maxSum);
        }
    }
}
