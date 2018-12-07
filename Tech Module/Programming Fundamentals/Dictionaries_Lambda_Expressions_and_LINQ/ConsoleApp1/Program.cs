using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Java C# PHP PHP JAVA C java

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();


            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word) == false)
                {
                    wordCount.Add(word, 0);
                }
                wordCount[word]++;
            }

            var result = new List<string>();


            foreach (var word in wordCount)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
