using System;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string patternDidi = @"[^A-Za-z-]+";
            string patternBojo = @"[A-Za-z]+-[A-Za-z]+";

            Regex regexDidi = new Regex(patternDidi);
            Regex regexBojo = new Regex(patternBojo);

            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (!didiMatch.Success)
                {
                    break;
                }
                Console.WriteLine(didiMatch.Value);

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = regexBojo.Match(input);
                if (!bojoMatch.Success)
                {
                    break;
                }
                Console.WriteLine(bojoMatch.Value);

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
