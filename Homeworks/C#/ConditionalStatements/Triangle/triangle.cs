using System;

    class triangle
    {
        static void Main(string[] args)
        {
            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(bX - cX, 2) + Math.Pow(bY - cY, 2));
            double b = Math.Sqrt(Math.Pow(aX - cX, 2) + Math.Pow(aY - cY, 2));
            double c = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2));

            bool isTriangle = (a + b > c) && (a + c > b) && (c + b > a);

            double p = (a + b + c) / 2;

            if (isTriangle)
            {
                Console.WriteLine("Yes");
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", c);
            }
        }
    }

