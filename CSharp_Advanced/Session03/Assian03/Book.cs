namespace Assian03
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string isbm, string title, string[] author, DateTime Publication, decimal price)
        {
            ISBN = isbm;
            Title = title;
            Authors = new string[author.Length];
            for (int i = 0; i < author.Length; i++)
            {
                Authors[i] = author[i];
            }
            PublicationDate = Publication;
            Price = price;
        }

        public override string ToString()
        {
            return $"\nISBN: {ISBN}" +
                   $"\nTitle: {Title}" +
                   $"\nAuthors: {string.Join(" ", Authors)}" +
                   $"\nPublicationDate: {PublicationDate}" +
                   $"\nPrice: {Price}";
        }
    }
}
