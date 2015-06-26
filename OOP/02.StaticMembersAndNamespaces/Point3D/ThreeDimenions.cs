using System;
using System.Collections.Generic;

    class SMN
    {
        static void Main()
        {
            //Point3D Test
            Point3D pointA = new Point3D(5, 5, 5);
            var startingPoint = Point3D.StartingPoint;
            Console.WriteLine("Starting {0}",startingPoint);
            Console.WriteLine("Current {0}",pointA);

            Console.WriteLine();

            //Distance Calculator Test
            var pointB = new Point3D(2,2,2);
            Console.WriteLine("The distance between {0} and {1} = {2:F4}", 
                pointA, pointB, DistanceCalculator.CalculateTheDistance(pointA,pointB));
            Console.WriteLine();

            //Paths3D Test
            var pointC = new Point3D(1, 3, 1);
            var points = new List<Point3D>() {pointA, pointB, pointC };
            var path = new Paths3D(points);
            Console.WriteLine(path);
        }
    }
