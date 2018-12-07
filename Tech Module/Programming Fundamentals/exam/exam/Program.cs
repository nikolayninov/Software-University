using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> dist = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToList();

            BigInteger result = 0;

            while (dist.Count != 0)
            {
                int ind = int.Parse(Console.ReadLine());
                if (ind < 0)
                {
                    BigInteger pokDist = dist[0];
                    result += dist[0];
                    dist[0] = dist[dist.Count - 1];
                    for (int i = 0; i < dist.Count; i++)
                    {
                        if (dist[i] <= pokDist)
                        {
                            dist[i] += pokDist;
                        }
                        else
                        {
                            dist[i] -= pokDist;
                        }
                    }
                }
                else if (ind > (dist.Count - 1))
                {
                    BigInteger pokDist = dist[dist.Count - 1];
                    result += dist[dist.Count - 1];
                    dist[(dist.Count-1)] = dist[0];
                    for (int i = 0; i < dist.Count; i++)
                    {
                        if (dist[i] <= pokDist)
                        {
                            dist[i] += pokDist;
                        }
                        else
                        {
                            dist[i] -= pokDist;
                        }
                    }
                }
                else
                {
                    BigInteger pokDist = dist[ind];
                    result += pokDist;
                    dist.RemoveAt(ind);
                    for (int i = 0; i < dist.Count; i++)
                    {
                        if (dist[i] <= pokDist)
                        {
                            dist[i] += pokDist;
                        }
                        else
                        {
                            dist[i] -= pokDist;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}