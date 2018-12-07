using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Lambda_Expressions_and_LINQ_HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            var checks = new List<string>();

            bool check = false;

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
                else if (ins[0] == "ListAll")
                {
                    check = true;
                }
                else if (ins[0] == "END")
                {
                    break;
                }
            }

            

            foreach (var a in checks)
            {
                if (phoneBook.ContainsKey(a))
                {
                    Console.WriteLine($"{check} -> {phoneBook[a]}");
                }
                else
                {
                    Console.WriteLine($"Contact {check} does not exist.");
                }
            }

            if (check)
            {
                foreach (var phone in phoneBook)
                {
                    Console.WriteLine($"{phone.Key} -> {phone.Value}");
                }
            }
        }
    }
}
