using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\d{2})-(\w{3})-(\d{4})");
            var text = "This text has date: 20-Jan-2018 12-Mar-2028 30-Apr-2011";

            var matches = regex.Matches(text);
            var buba = matches.ToList();
            foreach (Match match in buba)
            {
                Console.WriteLine(match);
            }
        }
    }
}
