
namespace LoggerApp.Core
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Appenders.Contracts;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(args);

            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] args = input.Split('|');

                this.commandInterpreter.AddMessage(args);

                input = Console.ReadLine();
            }
            this.commandInterpreter.PrintInfo();
        }
    }
}