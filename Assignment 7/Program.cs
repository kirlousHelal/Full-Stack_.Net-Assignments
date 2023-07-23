namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Book> blist = new List<Book>();

            string[] authors = new string[] { "kiro ", "helal" };
            blist.Add(new Book("ISBN1", "Book1", authors, DateTime.Now, 2000));
            blist.Add(new Book("ISBN2", "Book2", authors, DateTime.Now, 3000));
            blist.Add(new Book("ISBN3", "Book3", authors, DateTime.Now, 4000));
            blist.Add(new Book("ISBN4", "Book4", authors, DateTime.Now, 5000));
            blist.Add(new Book("ISBN5", "Book5", authors, DateTime.Now, 6000));

            LibraryEngine.ProcessBooks(blist, BookFunctions.GetTitle);
        }
    }
}