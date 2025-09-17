namespace Assian03
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Title: {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            return $"Authors: {string.Join(" ", B.Authors)}";
        }
        public static string GetPrice(Book B)
        {
            return $"Price: {B.Price}";
            ;
        }

    }
}
