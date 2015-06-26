using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadArraysEqv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert First Length!");
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];

            Console.WriteLine("Insert elements of the first array");
            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert Second Length!");
            int m = int.Parse(Console.ReadLine());
            int[] secondArr = new int[m];

            Console.WriteLine("Insert elements of the second array");
            for (int i = 0; i < m; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            bool isEqv = false;

            if (n == m)
            {
                for (int i = 0; i < n; i++)
                {
                    isEqv = false;
                    if (firstArr[i] == secondArr[i])
                    {
                        isEqv = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Are arrays equal? {0}", isEqv);

        }
    }
}

