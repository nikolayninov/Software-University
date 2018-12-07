using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_And_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat
            {
                Name = "Gosho",
                Age = 2
            };
            
            cat.SayHello();
        }
    }
}
