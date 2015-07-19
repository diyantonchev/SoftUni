using System;
using System.Linq;

class Search
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int element = int.Parse(Console.ReadLine());
       
        Array.Sort(array);

        int index = PerformBinarySearch(array, element);

       Console.WriteLine(index);      
    }

    private static int PerformBinarySearch<T>(T[] array, T element)  where T : IComparable
    {
        int min = 0;
        int max = array.Length - 1;
        int index = -1;

        while (max > min)
        {
            int mid = min + (max - min) / 2;

            if (array[mid].CompareTo(element) == 0)
            {
                while (mid >= 0 && array[mid].CompareTo(element) == 0)
                {
                    index = mid;
                    mid--;
                }

                return index;
            }
            else if (array[mid].CompareTo(element) == -1)
            {
                min = mid;
            }
            else
            {
                max = mid;
            }
        }

        return index;
    }
}