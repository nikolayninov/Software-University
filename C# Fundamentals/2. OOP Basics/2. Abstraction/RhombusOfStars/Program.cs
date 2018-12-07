using System;
using System.Text;

namespace RhombusOfStars {
    class Program {
        static void Main(string[] args) {
            int size = Int32.Parse(Console.ReadLine());
            for (int starCount = 1; starCount <= size; starCount++) {
                PrintRow(size, starCount);
            }
            for (int starCount = size - 1; starCount >= 1; starCount--) {
                PrintRow(size, starCount);
            }
        }
        static void PrintRow(int figureSize, int starCount) {
            System.Console.WriteLine($"{new String(' ', figureSize - starCount)}{new StringBuilder().Insert(0,"* ", starCount-1).ToString()}*");
        }
    }
}