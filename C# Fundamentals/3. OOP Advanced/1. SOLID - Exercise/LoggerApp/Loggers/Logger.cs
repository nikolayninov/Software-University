namespace LoggerApp.Loggers
{
    using System;

    using Contracts;
    using Appenders.Contracts;
    using Enums;
    public class Logger : ILogger
    {
        private readonly IAppender consoleAppender;
        private readonly IAppender fileAppender;

        public Logger(IAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }
        public Logger(IAppender consoleAppender, IAppender fileAppender) : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }
        public void Error(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.ERROR, errorMessage);
        }
        internal void Critical(string dateTime, string criticalMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.CRITICAL, criticalMessage);

        }

        internal void Warning(string dateTime, string criticalMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.WARNING, criticalMessage);
        }

        internal void Fatal(string dateTime, string fatalMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.FATAL, fatalMessage);

        }
        public void Info(string dateTime, string infoMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.INFO, infoMessage);

        }
        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            this.fileAppender?.Append(dateTime, reportLevel, message);
            this.consoleAppender.Append(dateTime, reportLevel, message);
        }
    }
}