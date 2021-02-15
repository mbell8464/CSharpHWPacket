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
            //************STUDENT*************
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

        }
    }
}
