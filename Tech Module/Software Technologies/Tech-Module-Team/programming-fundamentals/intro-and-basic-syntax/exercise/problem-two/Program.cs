using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // We recieve width and height
            var width = double.Parse(Console.ReadLine());
            var heigth = double.Parse(Console.ReadLine());

            // We calculate the area and print it out
            Console.WriteLine($"{width * heigth:f2}");
        }
    }
}
