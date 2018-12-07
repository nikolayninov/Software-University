using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsInpt = Console.ReadLine().Split(' ').Select(Int32.Parse);
            var bottlesInpt = Console.ReadLine().Split(' ').Select(Int32.Parse);
            
            Queue<int> cups = new Queue<int>(cupsInpt);
            Stack<int> bottles = new Stack<int>(bottlesInpt);

            int wastedWater = 0;

           while ( cups.Count > 0 && bottles.Count > 0 )
           {
               int bottleWater = bottles.Pop();
               int cupWater = cups.Peek();
               if(bottleWater >= cupWater)
               {
                   wastedWater += bottleWater - cupWater;
                   cups.Dequeue();
                   continue;
               }
               var newCups = cups.ToArray();
               newCups[0] -= bottleWater;
               cups = new Queue<int>(newCups);            
           }
           
           if(cups.Count > 0)
           {
               System.Console.WriteLine($"Cups: {String.Join(" ", cups)}");
           }
           else 
           {
               System.Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
           }
           System.Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
