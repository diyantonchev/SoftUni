using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] cube = new int[10, 10, 10];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write(cube[i,j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
