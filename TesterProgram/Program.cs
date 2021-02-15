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





        }
    }
}
