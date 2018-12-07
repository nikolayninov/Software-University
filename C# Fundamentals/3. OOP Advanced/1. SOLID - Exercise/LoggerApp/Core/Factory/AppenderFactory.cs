namespace LoggerApp.Core.Factory
{
    using System;

    using Contracts;
    using LoggerApp.Appenders;
    using LoggerApp.Appenders.Contracts;
    using LoggerApp.Layouts.Contracts;
    using LoggerApp.Loggers;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLowerCase = type.ToLower();
            switch (typeAsLowerCase)
            {

                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}