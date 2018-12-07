namespace LoggerApp.Loggers.Contracts
{
    public interface ILogFile
    {
        void Write(string message);
        int Size { get; }
    }
}