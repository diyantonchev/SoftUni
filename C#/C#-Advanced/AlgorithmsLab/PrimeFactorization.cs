using System;
using System.Collections.Generic;
using System.Linq;

class PrimeFactorization
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var primeMultiples = new List<int>();
        int divisor = 2;

        int number = n;
        while (number != 1)
        {
            if (number % divisor == 0)
            {
                primeMultiples.Add(divisor);
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        var output = primeMultiples.OrderBy(x => x);

        Console.WriteLine("{0} = {1}",n, string.Join(" * ",output));
    }
 }