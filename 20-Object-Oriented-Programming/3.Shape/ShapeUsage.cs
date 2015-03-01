using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Shape
{
    class ShapeUsage
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(3, 4);
            Console.WriteLine(triangle.CalculateSurface());

            Rectangle rectangle = new Rectangle(4, 10);
            Console.WriteLine(rectangle.CalculateSurface());

            Circle circle = new Circle(4);
            Console.WriteLine(circle.CalculateSurface());

            Console.ReadKey();
        }
    }
}
