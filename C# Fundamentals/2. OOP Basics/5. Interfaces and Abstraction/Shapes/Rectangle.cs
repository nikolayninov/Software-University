namespace StartUp
{
    using System;
    public class Rectangle : IDrawable
    {
        private int width;
        public int Width
        {
            get { return width; }
            private set
            {
                if (value <= 4)
                {
                    throw new ArgumentException("Width must be minimum 4");
                }
                width = value;
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            private set
            {
                if (value <= 4)
                {
                    throw new ArgumentException("Height must be minimum 4");
                }
                height = value;
            }
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void Draw()
        {
            System.Console.WriteLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                System.Console.WriteLine($"*{new String(' ',Width-2)}*");
            }
            System.Console.WriteLine(new string('*', Width));
        }
    }
}