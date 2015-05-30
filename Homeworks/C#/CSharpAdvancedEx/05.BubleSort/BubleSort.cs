using System;
class BubleSort
{
    static void Main()
    {
        int[] numbers = { 5, 2, 13, 11, 7, 10, 6, 4, 8, 12, 9, 1, 15, 3, 14 };

        while (true)
        {
            bool hasSwapped = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int prevIndex = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = prevIndex;

                    hasSwapped = true;
                }
            }

            if (hasSwapped == false)
            {
                break;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " " );
        }
    }
}
