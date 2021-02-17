using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields

        //properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        //constructors
        public Library()
        {

        }
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        //methods

        public override string ToString()
        {
            string allBooks = "";
            foreach (Book book in Books)
            {
                allBooks += book + "\n";
            }
            return string.Format($"Library Name: {LibraryName}\nLocation: {StreetAddress}\nCity: {City}\nState: {State}\nZip: {Zip}\n\nBooks:\n{allBooks}\n");
        }
    }
}
