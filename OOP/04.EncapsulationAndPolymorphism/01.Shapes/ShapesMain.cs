using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            var circle = new Circle(10.5);
            var rectangle = new Rectanlge(4.5, 5.4);
            var triangle = new Triangle(5, 6, 4, 5);

            var shapes = new List<IShape>()
            {
                circle,
                rectangle,
                triangle
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} -> Area: {1:F4}; Perimeter: {2:F4};", 
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
