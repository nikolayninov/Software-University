using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Strings_and_Text_Processing_HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(BigInteger.Parse)
                            .ToArray();

            BigInteger baseN = numbers[0];
            BigInteger number = numbers[1];
            var resultN = new List<string>();

            while (number != 0)
            {
                resultN.Add((number % baseN).ToString());
                number = number / baseN;
            }

            var result = new StringBuilder();
            resultN.Reverse();

            foreach (var bit in resultN)
            {
                result.Append(bit);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
