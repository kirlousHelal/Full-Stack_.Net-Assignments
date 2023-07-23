using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{

    public delegate T BookFuncDelgt<out T>(Book B);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            //throw new NotImplementedException();
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;

        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return $"The ISBN : {ISBN} , " +
                $"The Title : {Title} , " +
                $"The Authors : {Authors} , " +
                $"The PublicationDate : {PublicationDate} , " +
                $"The Price : {Price}";
        }
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B?.Title;
            //throw new NotImplementedException();
        }
        public static string GetAuthors(Book B)
        {
            string str="";
            for (int i = 0; i < B?.Authors?.Length; i++)
            {
                str+= B.Authors[i].ToString()+"\n";
            }
            return str;
            //throw new NotImplementedException();
        }
        public static string GetPrice(Book B)
        {
            return $"The Price is {B?.Price}";
            //throw new NotImplementedException();
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks<T>(List<Book> bList,/*Pointer To BookFunciton*/BookFuncDelgt<T> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr.Invoke(B));
            }
        }
    }
}
