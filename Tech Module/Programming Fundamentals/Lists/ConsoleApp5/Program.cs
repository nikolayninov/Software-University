using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textList = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(
                    s => Split(new char)     
                );
        }
    }
}
