using System;

    class Point
     {
        static void Main(string[] args)
        {
            int radius = 2;
            int centerX = 0;
            int centerY = 0;

            double x = 1.5;
            double y = 1;

            double pointX = x - centerX;
            double pointY = y - centerY;

            bool inCircleK = Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= Math.Pow(radius, 2);
            
            if (inCircleK)
            {
                Console.WriteLine("The point is inside a circle K.");
            }
            else
            {
                Console.WriteLine("The point is not inside a circle K.");
            }
        }
    }

