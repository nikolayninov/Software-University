using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            if (n % 2 == 0)
            {
                for (int i = 1; i < (n - 2) / 2 ; i++)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*");
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
            }
            else
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*");
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
            }
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
