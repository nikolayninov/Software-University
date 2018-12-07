using System;

namespace Conditional_Statements_and_Loops__Lab
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int pesho = int.Parse(Console.ReadLine());
            int gosho = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            string attPesho = "Roundhouse kick";
            string attGosho = "Thunderous fist";

            int counter = 0;

            while (true)
            {
                counter++;
                
                if(counter % 2 != 0)
                {
                    goshoHealth -= pesho;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used {attPesho} and reduced Gosho to {goshoHealth} health.");
                    if (counter % 3 == 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                }
                else
                {
                    peshoHealth -= gosho;                  

                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used {attGosho} and reduced Pesho to {peshoHealth} health.");
                    if (counter % 3 == 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                }
                
            }      
        }
    }
}
