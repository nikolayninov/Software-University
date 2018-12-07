using System;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var ferrari = new Ferrari(name);
            System.Console.WriteLine(ferrari);
        }
    }
}