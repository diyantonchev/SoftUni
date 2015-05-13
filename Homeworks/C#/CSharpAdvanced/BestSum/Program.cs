using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
               {7, 1, 3, 3, 2, 1},
               {1, 3, 9, 8, 5, 6},
               {4, 6, 7, 9, 1, 0}
    
            };

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);                                                             
            Console.WriteLine(" {0} {1}", matrix[bestRow +1 , bestCol], matrix[bestRow + 1, bestCol + 1] );
            Console.WriteLine("The maximal sum is {0}", bestSum);
        }
    }
}
