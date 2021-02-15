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





        }
    }
}
