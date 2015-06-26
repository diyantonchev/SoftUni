using System;
   
public static class DistanceCalculator
    {
       public static double CalculateTheDistance(Point3D a, Point3D b)
       {
           double xSquare = (a.CoordinateX * a.CoordinateX) - (b.CoordinateX * b.CoordinateX);
           double ySquare = (a.CoordinateY * a.CoordinateY) - (b.CoordinateY * b.CoordinateY);
           double zSquare = (a.CoordinateZ * a.CoordinateZ) - (b.CoordinateX * b.CoordinateZ);

           return Math.Sqrt(xSquare + ySquare + zSquare);
       }
    }
