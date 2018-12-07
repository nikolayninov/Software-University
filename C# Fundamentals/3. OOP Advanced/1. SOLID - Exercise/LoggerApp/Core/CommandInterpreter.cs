namespace LoggerApp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Appenders.Contracts;
    using Factory.Contracts;
    using Factory;
    using Loggers.Enums;
    using Layouts.Contracts;
    using Contracts;
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;
        public CommandInterpreter()
        {
            this.appenders = new LinkedList<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;
            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            IAppender appender = this.appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;

            this.appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0]);
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Logger info");

            foreach (var app in appenders)
            {
                System.Console.WriteLine(app);
            }
        }
    }
}