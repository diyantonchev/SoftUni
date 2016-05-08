using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Sort
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbs = numbers.Split(' ');

            int[] integers = new int[numbs.Length];

            for (int i = 0; i < numbs.Length; i++)
            {
                integers[i] = int.Parse(numbs[i]);
            }

            int[] sorted = BubleSort(integers);
            Console.WriteLine(string.Join(" ", sorted));
        }

        public static int[] BubleSort(int[] integers)
        {
            int temp = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = 0; j < integers.Length - 1; j++)
                {
                    if (integers[j] > integers[j + 1])
                    {
                        temp = integers[j + 1];
                        integers[j + 1] = integers[j];
                        integers[j] = temp;
                    }
                }
            }
            return integers;
        }
    }
}
