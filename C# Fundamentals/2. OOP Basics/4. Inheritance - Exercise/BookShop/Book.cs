namespace BookShop
{
    using System.Linq;
    using System.Text.RegularExpressions;
    using System;
    public class Book
    {
        public string title;
        public string author;
        public decimal price;

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                var splitNames = value.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (splitNames.Length > 1 && char.IsDigit(splitNames[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }
        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                $"Title: {this.title}\n" +
                $"Author: {this.author}\n" +
                $"Price: {this.price:F2}";
        }
    }
}