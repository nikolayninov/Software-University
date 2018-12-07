using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Startup
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle(4, 6);
            IShape square = new Square(4);
            IShape circle = new Circle(10);
            IEnumerable<IShape> shapes = new List<IShape>()
            {
                rectangle,
                square,
                circle
            };

            foreach (var shape in shapes)
            {
                System.Console.WriteLine(shape.CalculateArea());
            }
        }
    }
}