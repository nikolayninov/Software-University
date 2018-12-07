using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Person();
            Mammal mammal = new Person();
            Person person = new Person();
            Cat cat = new Cat();
            Walk(person);
            Walk(mammal);
            person.Age = 21;
            Eat(person);
            Eat(cat);
        }
        public static void Walk(IAnimal animal)
        {
            animal.Walk();
        }
        public static void Eat(Mammal animal)
        {
            animal.Eat();
        }
    }
}