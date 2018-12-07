namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price * (decimal) 1.3)
        {

        }

    }
}