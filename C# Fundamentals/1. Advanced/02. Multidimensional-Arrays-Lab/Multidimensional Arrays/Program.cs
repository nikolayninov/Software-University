using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(',')
                .Select(Int32.Parse)
                .ToArray();

            var matrix = new int[sizes[0], sizes[1]];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                .Split(',')
                .Select(Int32.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                    sum += columnElements[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
