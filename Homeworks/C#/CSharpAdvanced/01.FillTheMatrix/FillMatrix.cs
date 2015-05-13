using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the matrix.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrixA = new int[n, n];
            int countA = 1;

            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                for (int row = 0; row < matrixA.GetLength(0); row++)
                {
                    matrixA[row, col] = countA;
                    countA++;
                }
            }

            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixA.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixA[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] matrixB = new int[n, n];
            int countB = 1;

            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrixB.GetLength(0); row++)
                    {

                        matrixB[row, col] = countB;
                        countB++;
                    }
                }
                else
                {
                    for (int row = matrixB.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrixB[row, col] = countB;
                        countB++;
                    }
                }
            }
            for (int row = 0; row < matrixB.GetLength(0); row++)
            {
                for (int col = 0; col < matrixB.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrixB[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] spiralMatrix = new int[n, n];
            int counter = 1;

            for (int row = 0; row < spiralMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < spiralMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", spiralMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
