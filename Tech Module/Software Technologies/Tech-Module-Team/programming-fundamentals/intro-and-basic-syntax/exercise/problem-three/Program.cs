using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {   
            // We recieve distance in kilometers
            var distance = double.Parse(Console.ReadLine());
            // We define miles const
            var distanceInMiles = distance * 1.60934;
            // We calculate the distance in miles and print it out
            Console.WriteLine($"{distanceInMiles:f2}");
        }
    }
}
