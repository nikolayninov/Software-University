using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if(city == "Sofia")
            {
                switch (food)
                {
                    case "coffee":
                        Console.WriteLine(0.50 * number);
                        break;
                    case "water":
                        Console.WriteLine(0.80 * number);
                        break;
                    case "beer":
                        Console.WriteLine(1.20 * number);
                        break;
                    case "sweets":
                        Console.WriteLine(1.45 * number);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.60 * number);
                        break;
                }
            }else if(city == "Plovdiv")
            {
                switch (food)
                {
                    case "coffee":
                        Console.WriteLine(0.40 * number);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * number);
                        break;
                    case "beer":
                        Console.WriteLine(1.15 * number);
                        break;
                    case "sweets":
                        Console.WriteLine(1.30 * number);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.50 * number);
                        break;
                }
            }
            else
            {
                switch (food)
                {
                    case "coffee":
                        Console.WriteLine(0.45 * number);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * number);
                        break;
                    case "beer":
                        Console.WriteLine(1.10 * number);
                        break;
                    case "sweets":
                        Console.WriteLine(1.35 * number);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.55 * number);
                        break;
                }
            }
        }
    }
}
