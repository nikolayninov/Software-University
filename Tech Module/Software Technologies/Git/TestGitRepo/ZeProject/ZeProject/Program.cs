using System;
using System.Text;

namespace ZeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt = Console.ReadLine();
            var bld = new StringBuilder();
            int key = inpt.Length;
            foreach (var lt in inpt)
            {
                bld.Append((char) (lt + key));
            }
            Console.WriteLine(bld);
        }
    }
}
