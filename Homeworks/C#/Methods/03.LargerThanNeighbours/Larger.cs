using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class Larger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers for array, separated by space");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(isLargerThanNeighbours(arr, i));
            }

        }
        static bool isLargerThanNeighbours(int[] numbers, int index)
        {
            bool isLarger = false;

            if (numbers[index] != numbers[0] && numbers[index] != numbers[numbers.Length - 1])
            {
                if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                {
                    isLarger = true;
                }
            }
            else
            {
                if (numbers[index] == numbers[0])
                {
                    if (numbers[0] > numbers[1])
                    {
                        isLarger = true;
                    }
                }
                else if (numbers[index] == numbers[numbers.Length - 1])
                {
                    if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                    {
                        isLarger = true;
                    }                
                }
            }
            return isLarger;
        }
    }
}
