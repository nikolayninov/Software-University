using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine().Split(' ');

            int n = Int32.Parse(parameters[0]);
            int pops = Int32.Parse(parameters[1]);
            int lookingFor = Int32.Parse(parameters[2]);

            var integers = Console.ReadLine().Split(' ').Select(Int32.Parse);

            var st = new Queue<int>(integers);

            for (int i = 0; i < pops; i++)
            {
                st.Dequeue();
            }

            if (st.Contains(lookingFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (st.Count > 0)
                {
                    int minNumInStack = int.MaxValue;
                    foreach (var num in st)
                    {
                        if (num < minNumInStack)
                        {
                            minNumInStack = num;
                        }
                    }
                    Console.WriteLine(minNumInStack);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

        }
    }
}
