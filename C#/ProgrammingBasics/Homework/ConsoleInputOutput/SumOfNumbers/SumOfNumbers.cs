using System;

    class SumOfNumbers
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Insert a number n!");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter {0} numbers!", n);
                double sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    sum += number;
                    Console.WriteLine("sum = {0}", sum);
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            
        }
    }

