namespace Shapes
{
   public class Rectanlge : BasicShape
    {
        public Rectanlge(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public static double CalculateArea(double width, double height)
        {
            double area = width * height;

            return area;
        }

        public static double CalculatePerimeter(double width, double height)
        {
            double perimeter = 2 * (width + height);

            return perimeter;
        }
    }
}
