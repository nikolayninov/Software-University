using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"<ul><li><a href=""http://softuni.bg"">Softuni</a></li></ul>";
            var regex = new Regex(@"<a.+href=""(.+?)"">(.+?)</a>");
            var matches = regex.Matches(text);

            var result = regex.Replace(text, "[URL href=\"$1\"]$2[/URL]");
            Console.WriteLine(result);
        }
    }
}
