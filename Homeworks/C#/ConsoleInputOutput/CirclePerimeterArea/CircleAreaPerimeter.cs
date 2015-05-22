using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class CircleAreaPerimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of a circle!");
            double radius = float.Parse(Console.ReadLine());
           
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("r = " + radius);
            Console.WriteLine("Area --> {0:F2}", area);
            Console.WriteLine("Perimeter --> {0:F2}",  perimeter);
        }
    }
}
