using System;

    class TheBiggestNumb
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            if (a == b && b == c) 
            {
                Console.WriteLine("The numbers are equal.");
            }   
        }
    }

