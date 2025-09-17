namespace Assian03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] auth = { "Sam", "Ali", "fvbn" };

            Book b = new Book("12345", "Cairo", auth, DateTime.Now, 50);

            Book b2 = new Book("52142", "Alex", auth, DateTime.Now, 70);

            List<Book> list = new List<Book>() { b, b2 };


            // a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            LibraryDelegate _ref = BookFunctions.GetTitle;
            //string res = _ref(b);
            //Console.WriteLine(res);

            LibraryEngine.ProcessBooks(list, _ref);

            // b) Use the Proper build in delegate. 
            Func<Book, string> func = BookFunctions.GetAuthors;
            //string res2 = func(b);
            //Console.WriteLine(res2);

            //LibraryEngine.ProcessBooks(list, func);

            //c) Anonymous Method (GetISBN).
            LibraryEngine.ProcessBooks(list, delegate (Book B)
            {
                return $"ISBN: {B.ISBN}";
            });


            //d) Lambda Expression (GetPublicationDate).

            LibraryEngine.ProcessBooks(list, B => $"PublicationDate: {B.PublicationDate}");


        }
    }
}
