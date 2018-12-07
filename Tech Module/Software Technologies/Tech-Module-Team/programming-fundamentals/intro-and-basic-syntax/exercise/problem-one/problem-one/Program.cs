using System;

namespace problem_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // We recieve 4 numbers
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            // Then we print then in 0000 format
            Console.WriteLine($"{one:d4} {two:d4} {three:d4} {four:d4}");
        }
    }
}
