using System;
using System.Collections.Generic;
using System.Linq;

class Pyramid
{
    static void Main()
    {
        int rowsCount = int.Parse(Console.ReadLine());

        var pyramid = new List<int[]>();
        for (int i = 0; i < rowsCount; i++)
        {
            pyramid.Add(Console.ReadLine()
                .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
        }

        int previousNumber = pyramid[0][0];
        var sequence = new List<int>(){previousNumber};
        for (int row = 1; row < pyramid.Count; row++)
        {
            bool hasFound = false;
            int closestNumber = int.MaxValue;
            for(int col = 0; col < pyramid[row].Length; col++)
            {
                int currentNumber = pyramid[row][col];
                if (currentNumber < closestNumber && currentNumber > previousNumber)
                {
                    closestNumber = currentNumber;
                    hasFound = true;
                }
             }
            if (hasFound)
            {
                sequence.Add(closestNumber);
                previousNumber = closestNumber;
            }
            else
            {
                previousNumber++;
            }
        }
        Console.WriteLine(string.Join(", ",sequence));
    }
}