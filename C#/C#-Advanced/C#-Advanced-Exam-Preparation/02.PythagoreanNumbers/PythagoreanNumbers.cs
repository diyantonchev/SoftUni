using System;
using System.Collections.Generic;
using System.Linq;

class PythagoreanNumbers
{
    static void Main()
    {
        int numbersOfInputRows = int.Parse(Console.ReadLine());

        var numbers = new List<int>();
        int counter = 0;
        while (counter < numbersOfInputRows)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
            counter++;
        }

        bool hasPythagoreanNumbers = false; 
        foreach (var a in numbers)
        {
            foreach (var b in numbers.Where(b => b >= a ))
            {
                foreach (var c in numbers.Where(c => c * c == (a*a + b * b)))
                {
                   Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                   hasPythagoreanNumbers = true;
                }
            }
        }
        if (!hasPythagoreanNumbers)
        {
            Console.WriteLine("No");
        }
    }
}