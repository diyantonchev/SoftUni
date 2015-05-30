using System;
using System.Collections.Generic;
using System.Linq;

    class LegoBlocks
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            
            int[][] firstJaggedArr = new int[rows][];
            int[][] secondJaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                firstJaggedArr[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int row = 0; row < rows; row++)
            {
                secondJaggedArr[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            int[][] reversed = ReverseArray(secondJaggedArr);

            bool isFit = false;
            for (int row = 0; row < rows - 1; row++)
            {
                if (firstJaggedArr[row].Length + reversed[row].Length == firstJaggedArr[row + 1].Length + reversed[row + 1].Length)
                {
                    isFit = true;
                }   
            }
            if (isFit)
            {
                var outputArr = new int[rows][];

                for (int row = 0; row < rows; row++)
                {
                    int[] currentArr = new int[firstJaggedArr[row].Length + reversed[row].Length];
                    int oldCol = 0;
                    for (int col = 0; col < (firstJaggedArr[row].Length + reversed[row].Length); col++)
                    {
                        if (col <= firstJaggedArr[row].Length - 1)
                        {
                            currentArr[col] = firstJaggedArr[row][col]; 
                        }
                        else
                        {
                            currentArr[col] = reversed[row][oldCol];
                            oldCol++;
                        }             
                    }
                    outputArr[row] = currentArr;
                }            
                PrintMatrix(outputArr);
            }
            else
            {
                int counter = 0;
                for (int row = 0; row < firstJaggedArr.GetLength(0); row++)
                {
                    for (int col = 0; col < firstJaggedArr[row].Length; col++)
                    {
                        counter++;
                    }
                }
                for (int row = 0; row < reversed.GetLength(0); row++)
                {
                    for (int col = 0; col < reversed[row].Length; col++)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("The total number of cells is: {0}", counter);
            }
        }

        private static int[][] ReverseArray(int[][] secondJaggedArr)
        {
            var reversed = new int[secondJaggedArr.GetLength(0)][];      
            for (int row = 0; row < reversed.GetLength(0); row++)
            {
                var currentRow = new int[secondJaggedArr[row].Length];
                int column = 0;
                for (int col = secondJaggedArr[row].Length - 1; col >= 0; col--)
                {
                    currentRow[column] = secondJaggedArr[row][col];
                    column++;
                }
                reversed[row] = currentRow;
            }
            return reversed;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                    Console.WriteLine("[{0}]",string.Join(", ",matrix[row]));
            }
        }
    }
