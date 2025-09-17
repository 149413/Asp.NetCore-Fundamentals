namespace Assian03
{
    delegate string LibraryDelegate(Book B);

    internal class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList, LibraryDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }

        }


        //public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }

        //}
    }
}
