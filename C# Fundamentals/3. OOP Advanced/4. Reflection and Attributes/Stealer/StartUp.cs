using System;

namespace Stealer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.AnalyzeAcessModifiers("Hacker");
            System.Console.WriteLine(result);
        }
    }
}
