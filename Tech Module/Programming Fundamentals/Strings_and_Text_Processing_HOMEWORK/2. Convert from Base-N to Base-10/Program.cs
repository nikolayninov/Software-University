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

            double baseN = (double) numbers[0];

            string number = numbers[1].ToString();

            BigInteger result = 0;

            BigInteger pow = number.Length - 1;

            for (BigInteger i = 0; i < number.Length; i++)
            {
                int num = number[(int)i] - '0';
                result += (BigInteger)( num * Math.Pow(baseN, (double)pow));
                pow--;
            }
            Console.WriteLine(result);
        }
    }
}
