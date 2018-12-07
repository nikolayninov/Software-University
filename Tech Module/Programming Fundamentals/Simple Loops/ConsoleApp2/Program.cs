using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0 && n >= 4)
            {
                int rows = (n - 3) / 2;
                Console.WriteLine(new string('-', (n - 2)/2) + "**" + new string('-', (n - 2) / 2));
                for(int i = 1; i <= rows;i++)
                {
                    Console.WriteLine(new string('-', (n - 2)/2 - i) + "*" + new string('-', (n - 2) - 2*((n-2)/2 - i)) + "*" + new string('-', (n - 2) / 2 - i));
                }
                Console.WriteLine("*" + new string('-', n - 2) + "*");
                for (int i = 1; i <= rows ; i++)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', n - 2 - 2 * i) + "*" + new string('-', i));
                }
                Console.WriteLine(new string('-', (n - 2) / 2) + "**" + new string('-', (n - 2) / 2));
            }
            else if(n % 2 != 0 && n >= 4)
            {
                int rows = (n - 3) / 2;
                Console.WriteLine(new string('-', (n - 1) / 2) + "*" + new string('-', (n - 1) / 2));
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine(new string('-', (n - 2) / 2 - i) + "*" + new string('-', (n - 2) - 2 * ((n - 2) / 2 - i)) + "*" + new string('-', (n - 2) / 2 - i));
                }
                Console.WriteLine("*" + new string('-', n - 2) + "*");
                for (int i = 1; i <= rows; i++)
                {
                    Console.WriteLine(new string('-', i) + "*" + new string('-', n - 2 - 2 * i) + "*" + new string('-', i));
                }
                Console.WriteLine(new string('-', (n - 1) / 2) + "*" + new string('-', (n - 1) / 2));
            }else if(n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
        }
    }
}
