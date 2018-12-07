using System;

namespace _7._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(Int32.Parse)
                .ToArray();

            jaggedArray[0] = input
                .Where(x => x % 3 == 0)
                .ToArray();

            jaggedArray[1] = input
                .Where(x => x % 3 == 1)
                .ToArray();

            jaggedArray[2] = input
                .Where(x => x % 3 == 2)
                .ToArray();

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(' ', item));
            }
        }
    }
}
