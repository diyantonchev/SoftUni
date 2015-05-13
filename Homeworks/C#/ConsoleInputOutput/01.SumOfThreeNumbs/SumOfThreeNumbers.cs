using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 3 Numbers!");

            try 
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
               
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }

