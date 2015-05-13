using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Input coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 ");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (d == 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {

                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            
        }
    }

