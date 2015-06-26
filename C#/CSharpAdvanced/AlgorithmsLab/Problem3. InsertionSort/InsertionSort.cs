using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sort
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        numbers = InsertionSort(numbers);
        Console.WriteLine(string.Join(" ", numbers));
    }
    static int[] InsertionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length-1; i++)
        {
            int j = i + 1;
            while (j > 0)
            {
                if (numbers[j-1] > numbers[j])
                {
                    int temp = numbers[j-1];
                    numbers[j-1] = numbers[j];
                    numbers[j] = temp;
                }
                j--;
            }
        }
        return numbers;
    }
}

