using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = 
            {                
                {1, 2, 3},
                {4, 5, 6}                                
            };
            int[,] secondMatrix = 
            {
                {7, 8},
                {9, 10},
                {11, 12}
            };
            int rows = firstMatrix.GetLength(0);
            int cols = secondMatrix.GetLength(1);

            int[,] result = new int[rows, cols];

            bool canMultiply = rows == cols;

            if (canMultiply)
            {
                for (int row = 0; row < result.GetLength(0); row++)
                {
                    for (int col = 0; col < result.GetLength(1); col++)
                    {
                        int currentResult = 0;
                        for (int element = 0; element < secondMatrix.GetLength(0); element++)
                        {
                            currentResult += firstMatrix[row, element] * secondMatrix[element, col];
                        }
                        result[row, col] = currentResult;
                    }
                }
                for (int row = 0; row < result.GetLength(0); row++)
                {
                    for (int col = 0; col < result.GetLength(1); col++)
                    {
                        Console.Write(" {0}", result[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid multiplication.");
            }

        }
    }
}
