using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Lambda_Expressions_and_LINQ_HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            var checks = new List<string>();

            while (true)
            {
                List<string> ins = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                if (ins[0] == "A")
                {
                    phoneBook[ins[1]] = ins[2];
                }
                else if (ins[0] == "S")
                {
                    checks.Add(ins[1]);
                }
                if (ins[0] == "END")
                {
                    break;
                }
            }

            foreach (var check in checks)
            {
                if (phoneBook.ContainsKey(check))
                {
                    Console.WriteLine($"{check} -> {phoneBook[check]}");
                }
                else
                {
                    Console.WriteLine($"Contact {check} does not exist.");
                }
            }
        }
    }
}
