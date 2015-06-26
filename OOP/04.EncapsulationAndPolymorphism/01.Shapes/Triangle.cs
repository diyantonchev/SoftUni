namespace Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private const double MinSideLength = 0;

        private double sideALength;
        private double sideCLength;

         public Triangle(double width, double height, double sideA, double sideC)
            : base(width, height)
        {
            this.SideA = sideA;
            this.SideC = sideC;
        }
        
        public double SideA
        {
            get { return this.sideALength; }

            set 
            {
                if (value <= MinSideLength)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative or zero.");
                }
                this.sideALength = value;
            }
        }
        
        public double SideC 
        {
            get { return this.sideCLength; }

            set
            {
                if (value < MinSideLength)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative.");
                }
                this.sideCLength = value;
            }
        }

        public override double CalculateArea()
        {
            double area = (this.Width * this.Height) / 2; 

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = sideALength + this.Width + sideCLength;

            return perimeter;
        }

        public static double CalculateArea(double width, double height)
        {
            double area = (width * height) / 2;

            return area;
        }

        public static double CalculatePerimeter(double sideALength,double width, double sideCLength)
        {
            double perimeter = sideALength + width + sideCLength;

            return perimeter;
        }
    }
}
