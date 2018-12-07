using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_And_Classes
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"My name is {Name}. Meow!");
        }
    }
}

