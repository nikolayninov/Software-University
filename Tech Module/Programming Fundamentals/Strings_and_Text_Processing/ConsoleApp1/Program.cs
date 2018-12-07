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
           var sb = "";

            for (int i = 0; i < 20; i++)
            {
                sb += Convert.ToString(i, 16);
            }

            Console.Write(sb.ToString());
        }
    }
}
