using System;
using System.Collections.Generic;

class PrimeFactorization
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        var primeNumbers = new List<uint>();
        uint divisor = 2;
        uint result = n;

        while (result != 1)
        {
            if (result % divisor == 0)
            {
                primeNumbers.Add(divisor);
                result = result / divisor;
            }
            else
            {
                divisor++;
            }
        }
        Console.WriteLine("{0} = {1}", n, string.Join(" * ", primeNumbers));
    }
}
