using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var R = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var sum = R * C;
            switch (type)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2} leva", sum * 12.00);
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2} leva", sum * 7.50);
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2} leva", sum * 5.00);
                    break;                
            }

        }
    }
}

