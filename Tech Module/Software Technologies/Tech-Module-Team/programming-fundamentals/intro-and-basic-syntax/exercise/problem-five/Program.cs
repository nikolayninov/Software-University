using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We recieve character's stats:
                - Name
                - Current Health
                - Maximum Health
                - Current Energy
                - Maximum Health                
            */
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            
            // Then we print everything in specific format
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', currentHealth) + new string ('.', maxHealth - currentHealth) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|");
        }
    }
}
