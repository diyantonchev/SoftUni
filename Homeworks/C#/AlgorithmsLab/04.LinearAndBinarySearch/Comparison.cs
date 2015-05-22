using System;
using System.Linq;
using System.Collections.Generic;

class Comparison
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long element = long.Parse(Console.ReadLine());

        var distinct = input.Distinct().ToArray();
        long[] arr = new long[distinct.Length];
        for (int i = 0; i < distinct.Length; i++)
        {
            arr[i] = long.Parse(distinct[i]);
        }

        Console.WriteLine(BinarySearch(arr, element));
    }
    static int LinearSearch(long[] arr, long element)
    {
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                index = i;
            }
        }
        return index;
    }

    static int BinarySearch(long[] arr, long element)
    {
        int index = -1;
        int min = 0;
        int max = arr.Length - 1;


        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (arr[mid] == element)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < element)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        return index;
    }
}

