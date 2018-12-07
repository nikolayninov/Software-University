
namespace LoggerApp.Core.Factory.Contracts
{
    using Layouts.Contracts;
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}