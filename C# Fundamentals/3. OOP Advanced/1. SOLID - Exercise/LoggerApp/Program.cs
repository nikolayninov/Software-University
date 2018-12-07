namespace LoggerApp
{
    using System;
    using System.Linq;
    using LoggerApp.Appenders;
    using LoggerApp.Appenders.Contracts;
    using LoggerApp.Layouts;
    using LoggerApp.Layouts.Contracts;
    using LoggerApp.Loggers;
    using LoggerApp.Loggers.Contracts;
    using LoggerApp.Loggers.Enums;
    using LoggerApp.Core.Contracts;
    using LoggerApp.Core;

    public class Program
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
