using System;

    class SumOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers!");          
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());
                double sum = a + b + c + d + e;

                Console.Write("numbers: {0} {1} {2} {3} {4} | sum: {5} ", a, b, c, d, e, sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }

