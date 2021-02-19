using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student            
            Console.WriteLine("\n\n******STUDENT*******\n\n");

            //long way
            Student s1 = new Student();
            s1.FirstName = "Michael";
            s1.LastName = "Scott";
            s1.Id = "1234";
            s1.GPA = 2.87f;

            //short way
            Student s2 = new Student("Dwight", "Schrute", "1235", 3.17f);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            #endregion

            #region Vehicle
            Console.WriteLine("\n\n******VEHICLE*******\n\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Kia";
            v1.Model = "Optima";
            v1.Year = 2015;
            v1.Weight = 0;//should display 4000 due to biz logic

            Vehicle v2 = new Vehicle("Ram", "1500", 2019, 5000f);           

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            #endregion

            #region Login
            Console.WriteLine("\n\n******Login*******\n\n");

            Login l1 = new Login();
            l1.Username = "ThisIsMyUserName";
            l1.Password = "ThisIsMyPassword";

            Login l2 = new Login("myUserName", "myPassword");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            #endregion

            #region Contact Info
            Console.WriteLine("\n\n******ContactInfo*******\n\n");

            ContactInfo contact1 = new ContactInfo();
            contact1.StreetAddress = "123 Main St";
            contact1.City = "Sprinfield";
            contact1.State = "Whoville";
            contact1.Zip = "12345";
            contact1.Phone = "123-456-7890";
            contact1.Email = "ThisIsMyEmail@Email.com";

            ContactInfo contact2 = new ContactInfo("987 Backup Rd", "Fallville", "Whatville", "98765", "987-654-3210", "MyEmail@Email.com");

            Console.WriteLine(contact1);
            Console.WriteLine(contact2);
            #endregion

            #region Customer
            Console.WriteLine("\n\n******Customer*******\n\n");

            Customer c1 = new Customer();
            c1.CustomerID = "1234";
            c1.FirstName = "Jim";
            c1.LastName = "Halpert";
            c1.ContactInformation = contact1;
            //c1.ContactInformation.StreetAddress = "456 2nd St";
            //c1.ContactInformation.City = "Scranton";
            //c1.ContactInformation.State = "Pennsylvania";
            //c1.ContactInformation.Zip = "12345";
            //c1.ContactInformation.Phone = "456-789-1230";
            //c1.ContactInformation.Email = "987-456-1478";

            Customer c2 = new Customer("456", "Pam", "Beasley", contact2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            #endregion

            #region CreditCardAccount
            Console.WriteLine("\n\n******Credit Card Account*******\n\n");

            CreditCardAccount cc1 = new CreditCardAccount();
            cc1.AccountNumber = 123456;
            cc1.CustomerInfo = c1;
            cc1.Balance = 142.24m;
            cc1.IsPastDue = false;
            cc1.AnnualInterestRate = 11.00m;

            CreditCardAccount cc2 = new CreditCardAccount(987654, c2, 2451.71m, true, 22.12m);

            Console.WriteLine(cc1);
            Console.WriteLine(cc2);
            #endregion

            #region Book
            Console.WriteLine("\n\n******Book*******\n\n");

            Book b1 = new Book();
            b1.Title = "The Great Big Book";
            b1.Author = "Shelly McShellerston";
            b1.NumberOfPages = 10;

            Book b2 = new Book("The Terrible Small Book", "Richard McRichardson", 875);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            #endregion

            #region Library
            Console.WriteLine("\n\n******Library*******\n\n");

            List<Book> books = new List<Book>();
            books.Add(b1);

            List<Book> books2 = new List<Book>() { b1, b2 };

            Library lb1 = new Library();
            lb1.Books = books;
            lb1.LibraryName = "The Great Library";
            lb1.StreetAddress = "123 Main St";
            lb1.City = "Springfield";
            lb1.State = "Mars";
            lb1.Zip = "12345";

            Library lb2 = new Library(books2, "The Okay Library", "456 Second Street", "Bigville", "Jupiter", "98765");

            Console.WriteLine(lb1);
            Console.WriteLine(lb2);

            #endregion

            #region Song
            Console.WriteLine("\n\n******Song*******\n\n");
            Song song1 = new Song();
            song1.Title = "Sand In My Boots";
            song1.Artist = "Morgan Wallen";
            song1.LengthInSeconds = 201;

            Song song2 = new Song("Whiskey'd My Way", "Morgan Wallen", 180);

            Console.WriteLine(song1);
            Console.WriteLine(song2);
            #endregion



        }
    }
}
