namespace Shapes
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }
        public Rectangle(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }
        public double CalculateArea()
        {
            return Width * Heigth;
        }
    }
}