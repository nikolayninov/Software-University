using System;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Seat seat = new Seat();
            System.Console.WriteLine(seat.Start());
            System.Console.WriteLine(seat.Stop());
            System.Console.WriteLine();
            Tesla tesla = new Tesla("p85", "Red");
            System.Console.WriteLine(tesla.Start());
            System.Console.WriteLine(tesla);
            System.Console.WriteLine(tesla.Stop());
            System.Console.WriteLine(tesla);
        }
    }
}