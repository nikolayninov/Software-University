using System;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* We recieve: 
                - name
                - volume
                - energy Content
                - sugar Content
            */ 
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());
            
            // We calculate the energy and sugar
            var energy = energyContent * volume / 100.0;
            var sugar = sugarContent * volume / 100.0;
            // Finally we print the result
            Console.WriteLine($"{volume}ml {name}:\n{energy}kcal, {sugar}g sugars");
        }
    }
}
