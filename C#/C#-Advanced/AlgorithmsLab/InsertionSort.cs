using System;
using System.Linq;

class InsertionSort
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i < numbers.Length; i++)
        {
            int previousIndex = i - 1;
            int currentIndex = i;
            while (previousIndex >= 0)
            {
                if (numbers[currentIndex] < numbers[previousIndex])
                {
                    int temp = numbers[previousIndex];
                    numbers[previousIndex] = numbers[currentIndex];
                    numbers[currentIndex] = temp;
                }
                else
                {
                    break;
                }

                previousIndex--;
                currentIndex--;
            }
        }

        Console.WriteLine(string.Join(" ",numbers));
    }
}