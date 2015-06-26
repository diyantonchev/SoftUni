using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerElement
    {
        static void Main(string[] args)
        {
            int[] arr = {1543, 542, 343, 343, 325, 2536, 537, 876, 869, 8};

            if (Larger(arr, 3))
            {
                Console.WriteLine("Yes");   
            }
            else
            {
                Console.WriteLine("No");
            }

            int index = FirstLarger(arr);
            Console.WriteLine("The index of first element larger than its neighbours -> {0}.", index);
            
        }
        static bool Larger(int[] array, int index)
        {
            bool isLarger = false;
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                isLarger = true;
            }
            return isLarger;

        }
        static int FirstLarger (int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (Larger(arr, i))
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
