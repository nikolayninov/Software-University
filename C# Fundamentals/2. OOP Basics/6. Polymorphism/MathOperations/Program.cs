using System;

namespace MathOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(MyMath.Add(1, 3));
            System.Console.WriteLine(MyMath.Add(1.4, 3.6));
            System.Console.WriteLine(MyMath.Add(1.4M, 3.6M));
        }
    }
}