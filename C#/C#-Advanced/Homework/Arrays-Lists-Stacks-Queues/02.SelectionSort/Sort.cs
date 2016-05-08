using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSort
{
    class Sort
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                int[] numbers = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    numbers[i] = int.Parse(input[i]);
                }

                SelectionSort(numbers);
                Console.WriteLine(string.Join(" ", numbers));
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input.");
            }
        }

        static int[] SelectionSort(int[] numbers)
        {
            int minIndex;
            int min;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    min = numbers[minIndex];
                    numbers[minIndex] = numbers[i];
                    numbers[i] = min;
                }
            }
            return numbers;
        }
    }
}
