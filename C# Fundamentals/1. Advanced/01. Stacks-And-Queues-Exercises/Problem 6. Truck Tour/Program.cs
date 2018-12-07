using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var pumps = new Queue<int>(n);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int fuel = input[0];
                int distance = input[1];

                pumps.Enqueue(fuel - distance);
            }

            for (int i = 0; i < n; i++)
            {

                int leftFuel = 0;

                foreach (var f in pumps)
                {
                    leftFuel += f;
                    if(leftFuel < 0)
                    {
                        break;
                    }
                }

                if(leftFuel > 0)
                {
                    Console.WriteLine(i);
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }
        }
    }
}
