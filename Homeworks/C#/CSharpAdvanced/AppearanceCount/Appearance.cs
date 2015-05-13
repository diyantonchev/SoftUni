using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Appearance
{
    static void Main(string[] args)
    {
        int[] arr = { 13, 34, 75, 44, 77, 10, 6, 7, 21, 31, 13, 5, 7, 54, 55, 64, 25, 67,
                        4, 67, 73, 73, 62, 12, 13, 12, 1, 5, 7, 34, 77, 6, 0, 9, 8, 1, 0,
                        1, 0, 56, 76, 7, 67, 34, 62, 62, 75, 12, 98, 89, 2, 1, 5, 44, 77};

        int numb = 1;
        int appearanceCount = Counter(arr, numb);
        Console.WriteLine(appearanceCount);

    }
    static int Counter(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }
        return count;
    }
}

