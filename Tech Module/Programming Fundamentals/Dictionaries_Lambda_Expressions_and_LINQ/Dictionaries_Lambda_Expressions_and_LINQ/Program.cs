using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Dictionaries_Lambda_Expressions_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>{ 1, 2, 3, 4, 5 };

            var first = list.FirstOrDefault(x => x > 3);
            var last = list.LastOrDefault(x => x > 3);

            Console.WriteLine(first + ", " +  last);
        }
    }
}
