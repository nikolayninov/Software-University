using System;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
using System.Text;


namespace Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultWithSb = new StringBuilder();

            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                resultWithSb.Append("a");
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
