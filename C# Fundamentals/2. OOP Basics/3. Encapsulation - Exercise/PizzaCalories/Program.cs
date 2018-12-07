using System;

namespace PizzaCalories {
    class Program {
        static void Main(string[] args) {
            Dough dough = new Dough("White", "Chewy", decimal.Parse(100));
            Console.WriteLine(dough.CalculateCalories());
        }
    }
}