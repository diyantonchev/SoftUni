using System;

    class PointsInside
    {
        static void Main(string[] args)
        {
            double radius = 1.5;
            double centerX = 1;
            double centerY = 1;

            double x = 1;
            double y = 2;

            double pointX = x - centerX;
            double pointY = y - centerY;

            bool inCircle = (Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= Math.Pow(radius, 2));

            bool check = inCircle && (y > 1);
            Console.WriteLine(check);
        }
    }

