using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = Int32.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowCount][];

            for (int i = 0; i < rowCount; i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(Int32.Parse)
                    .ToArray();

                jaggedArray[i] = currentRow;
            }

            string[] input = Console.ReadLine()
                .Split(' ');

            while (input[0]?.ToLower() != "end")
            {
                int row = Int32.Parse(input[1]);
                int col = Int32.Parse(input[2]);
                int value = Int32.Parse(input[3]);

                if (row < 0 ||
                   row > jaggedArray.Length - 1 ||
                   col < 0 ||
                   col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine()
                .Split(' ');
                    continue;
                }

                switch (input[0]?.ToLower())
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArray[row][col] -= value;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

                input = Console.ReadLine()
                .Split(' ');
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
