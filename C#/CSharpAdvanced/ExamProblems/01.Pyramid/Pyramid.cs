using System;
using System.Collections.Generic;

class Pyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var sequence = new List<int>();
        int prevNumber = int.Parse(Console.ReadLine().Trim());
        sequence.Add(prevNumber);
        for (int i = 1; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] numbersAsStrings = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numbersAsStrings.Length];
            for (int j = 0; j < numbersAsStrings.Length; j++)
            {
                numbers[j] = int.Parse(numbersAsStrings[j]);
            }

            int minNumber = int.MaxValue;
            bool foundNumber = false;
            for (int k = 0; k < numbers.Length; k++)
            {
                int currentNumber = numbers[k];
                if (currentNumber < minNumber && currentNumber > prevNumber)
                {
                    minNumber = currentNumber;
                    foundNumber = true;
                }
            }
            if (foundNumber)
            {
                sequence.Add(minNumber);
                prevNumber = minNumber;
            }
            else
            {
                prevNumber++;
            }           
        }
        Console.WriteLine(string.Join(", ", sequence));
    }
}
