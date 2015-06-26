using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side and an altitude to it:");
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double firstArea = TriangleArea(side, h);
            Console.WriteLine("Area = {0}", firstArea);

            Console.WriteLine("Enter three sides:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double p = TrianglePerimeter(a, b, c) / 2.0;
            double secondArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Area = {0:F2}", secondArea);

            Console.WriteLine("Enter two sides and an angle between them");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double altitude = Math.Sin(angle* (Math.PI/180)) * sideB;
            double thirdArea = TriangleArea(sideA, altitude);
            Console.WriteLine("Area = {0:F2}", thirdArea);

        }
        static double TriangleArea(double a, double h)
        {
            double area = (1 / 2.0) * a * h;
            return area;
        }

        static double TrianglePerimeter(double a, double b, double c)
        {
            double perimeter = a + b + c;
            return perimeter;
        }
    }
}
