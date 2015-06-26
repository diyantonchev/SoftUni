using System;
using Shapes.Interfaces;

namespace Shapes
{
    public class Circle : IShape
    {
        private const double PI = Math.PI;
        private const int MinRadius = 0;

        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value <= MinRadius)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative or zero.");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = PI * this.Radius * this.Radius;

            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * PI * this.Radius;

            return perimeter;
        }

        public static double CalculateArea(double radius)
        {
            double area = PI * radius * radius;

            return area;

        }

        public static double CalculatePerimeter(double radius)
        {
            double perimeter = 2 * PI * radius;

            return perimeter;
        }
    }
}
