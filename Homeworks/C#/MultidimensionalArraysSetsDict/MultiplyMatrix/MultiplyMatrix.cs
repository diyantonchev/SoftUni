using System;
using System.Collections.Generic;
using System.Linq;

    class MultiplyMatrix
    {
        static void Main()
        {
            double[,] firstMatrix = 
            {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 1, 5, 7 },
                { 2, 4, 6 }
            };

            double[,] secondMatrix = 
            {
                { 3, 5, 4 },
                { 7, 8, 5 },
                { 7, 9, 6 },
            };

            int firstMatrixRows = firstMatrix.GetLength(0);
            int firstMatrixCols = firstMatrix.GetLength(1);

            int secondMatrixRows = secondMatrix.GetLength(0);
            int secondMatrixCols = secondMatrix.GetLength(1);

            double[,] multipliedMatrix = new double[firstMatrixRows, secondMatrixCols];
 
            bool canMultiply = firstMatrixCols == secondMatrixRows;
            if (canMultiply)
            {
                for (int row = 0; row < multipliedMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < multipliedMatrix.GetLength(1); col++)
                    {
                        double currentElement = 0;
                        for (int element = 0; element < firstMatrix.GetLength(1); element++)
                        {
                            currentElement += firstMatrix[row, element] * secondMatrix[element, col];
                        }
                        multipliedMatrix[row, col] = currentElement;
                    }
                }

                for (int row = 0; row < multipliedMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < multipliedMatrix.GetLength(1); col++)
                    {
                        Console.Write("{0,-4}",multipliedMatrix[row,col]);   
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

