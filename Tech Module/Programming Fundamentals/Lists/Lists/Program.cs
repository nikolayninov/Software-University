using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                100,
                200,
                300
            };

            numbers.Add(400);
            numbers.Add(500);
            

            Console.WriteLine(string.Join(", ", numbers));

            numbers.Insert(3, 350);

            int[] numbersArr = { 20, 30, 40, 50 };
            numbers.AddRange(numbersArr);

            numbers.Sort();
            numbers.Reverse();



            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
