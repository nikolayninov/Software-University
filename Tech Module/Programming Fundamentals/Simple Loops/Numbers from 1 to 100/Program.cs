using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1111; i < 10000; i++)
            {
                int a = i / 1000;
                int d = i % 10;
                int c = ((i % 100 - d) / 10);
                int b = (i - a * 1000) / 100;
                if( (a + b) == (c + d) && n % (a + b) == 0 && a !=0 && b != 0 && c != 0 && d != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
