using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var seqQue = new Queue<long>(new long[] { n });
            int counter = 0;

            while (counter < 50)
            {
                if(seqQue.Count < 50)
                {
                    seqQue.Enqueue(n + 1);
                    seqQue.Enqueue(2 * n + 1);
                    seqQue.Enqueue(n + 2);
                }

                Console.Write(seqQue.Dequeue() + " ");
                n = seqQue.Peek();
                counter++;
            }
        }
    }
}
