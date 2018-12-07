using System;

namespace PointInRectangle {
    class Program {
        static void Main(string[] args) {
            Rectangle rectangle = new Rectangle() {
                TopLeft = new Point(3, 6),
                BottomRight = new Point(8, 4)
            };
            System.Console.WriteLine(rectangle.Contains(new Point(1, 5)));
            System.Console.WriteLine(rectangle.Contains(new Point(5, 4)));

        }
    }
}