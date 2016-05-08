using System;
using System.Collections.Generic;
using System.Linq;

class TheSieveOfEratosthenes
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = Enumerable.Range(0, n + 1).ToList();

        int currentPrime = 2;

        while (currentPrime < n)
        {
            for (int i = currentPrime * 2; i <= n; i += currentPrime)
            {
                numbers[i] = 0;
            }

            currentPrime++;
            while (numbers[currentPrime] < 2 && currentPrime < n)
            {
                currentPrime++;
            }
        }

        Console.WriteLine(string.Join(", ", numbers.Where(number => number >= 2)));
    }
}