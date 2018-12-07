using System;

namespace Demo
{
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            var books = new BooksCollection();
            books.Add(new Book { Title = "Gosho" });
            books.Add(new Book { Title = "Petyo" });
            books.Add(new Book { Title = "Stamat" });
            foreach (var book in books)
            {
                System.Console.WriteLine(book.Title);
            }
        }
    }
}
