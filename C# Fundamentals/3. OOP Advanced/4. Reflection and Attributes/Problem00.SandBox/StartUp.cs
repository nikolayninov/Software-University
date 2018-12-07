using System;
using System.IO;

namespace Problem00.SandBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Type type = Type.GetType("Problem00.SandBox.DummyClass");

            System.Console.WriteLine(type.GetProperties());
        }
    }
}
