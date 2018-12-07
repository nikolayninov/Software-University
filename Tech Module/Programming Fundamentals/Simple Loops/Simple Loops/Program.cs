using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string (' ', n) + "~ ~ ~");
            }
            Console.WriteLine(new string ('=', 3 * n +5));
            if (n % 2 == 0)
            {
                for (int i = 1; i <= (n - 3) / 2 + 1; i++)
                {
                    Console.WriteLine("|" + new string('~', 2 * n + 4) + "|" + new string(' ', n - 1) + "|");
                }
            }
            else
            {
                for (int i = 1; i <= (n - 3) / 2; i++)
                {
                    Console.WriteLine("|" + new string('~', 2 * n + 4) + "|" + new string(' ', n - 1) + "|");
                }
            }
            Console.WriteLine("|" + new string('~', n) + "JAVA" + new string('~', n) + "|" + new string(' ', n - 1) + "|");
            for (int i = 1; i <= (n - 3) / 2; i++)
            {
                Console.WriteLine("|" + new string('~', 2 * n + 4) + "|" + new string(' ', n - 1) + "|");
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine(new string(' ', j) + "\\" + new string ('@', 2 * n + 4 - j*2) + "/");
            }
            Console.WriteLine(new string('=', 2 * n + 6));
        } 
    }
}
