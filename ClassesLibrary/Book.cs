using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //constructors
        public Book()
        {

        }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }
        //methods

        public override string ToString()
        {
            return string.Format($"Book Title: {Title}\nAuthor: {Author}\nNumber of Pages: {NumberOfPages}\n");

        }
    }
}
