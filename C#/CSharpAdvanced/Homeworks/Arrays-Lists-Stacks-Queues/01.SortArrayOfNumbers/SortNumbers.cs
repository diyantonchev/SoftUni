using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArrayOfNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            string[] numbersString = Console.ReadLine().Split(' ');
            int[] numbersInt = new int[numbersString.Length];

            for (int i = 0; i < numbersString.Length; i++)
            {
                numbersInt[i] = int.Parse(numbersString[i]);
            }

            Array.Sort(numbersInt);
            Console.WriteLine(string.Join(" ", numbersInt));
           

        }
    }
}
