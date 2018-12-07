using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaxMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 7, 1, 3, 3, 2, 1},
                { 1, 3, 9, 8, 5, 6},
                { 4, 6, 7, 9, 1, 0}
            };

            int maxSum = Int32.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine(maxSum);
            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int col = colIndex; col < colIndex + 2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
