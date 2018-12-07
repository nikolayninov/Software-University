using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\r\nHealth: |" + new String('|', currentHealth) + new String('.', maxHealth - currentHealth) + "|");
            Console.WriteLine("Energy: |" + new String('|', currentEnergy) + new String('.', maxEnergy - currentEnergy) + "|");

        }
    }
}
