namespace LoggerApp.Core.Factory.Contracts
{
    using Appenders.Contracts;
    using Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}