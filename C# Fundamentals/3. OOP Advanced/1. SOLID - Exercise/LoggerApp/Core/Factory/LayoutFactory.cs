namespace LoggerApp.Core.Factory
{
    using System;

    using Contracts;
    using Layouts;
    using Layouts.Contracts;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}