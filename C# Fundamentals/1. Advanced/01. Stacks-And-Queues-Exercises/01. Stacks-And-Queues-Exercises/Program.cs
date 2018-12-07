using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Stacks_And_Queues_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ').Select(int.Parse);
            var integers = new Stack<int>(values);
            while (integers.Count > 1)
            {
                Console.Write(integers.Pop());
                Console.Write(" ");
            }
            Console.Write(integers.Pop());
        }
    }
}
