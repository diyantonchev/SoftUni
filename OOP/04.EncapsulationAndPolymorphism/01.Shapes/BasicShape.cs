namespace Shapes
{
    using System;
    using Shapes.Interfaces;

    public abstract class BasicShape : IShape
    {
        private const double MinWidth = 0;
        private const double MinHeight = 0;

        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {

            get { return this.width; }

            set
            {
                if (value <= MinWidth)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negetive or zero.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; } 
            
            set
            {
                if (value <= MinHeight)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative or zero.");
                }
                this.height = value;
            }
        }

       public abstract double CalculateArea();

       public abstract double CalculatePerimeter();

    }
}
