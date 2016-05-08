using System;
using System.Collections.Generic;
using System.Linq;

    class SubsetSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

            var subset = new List<int>();
            double combinations = Math.Pow(2, numbers.Length);

            bool isEqual = false;

            for (int i = 1; i < combinations; i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = i & (1 << j);
                    if (mask != 0)
                    {
                        sum += numbers[0 + j];
                        subset.Add(numbers[0 + j]);
                    }
                }

                if (sum == n)
                {
                    Console.WriteLine(string.Join(" + ", subset) + " = " + sum);
                    isEqual = true;
                }

                subset.Clear();
            }

            if (!isEqual)
            {
                Console.WriteLine("No matching subsets.");
            }
        }       
    }
