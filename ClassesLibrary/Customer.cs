using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        //private string _fullName;
        //properties
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }
        //public string FullName
        //{
        //    get { return _fullName; }
        //    set
        //    {
        //        _fullName = FirstName + LastName;
        //    }

        //}
        
        //constructors
        public Customer()
        {

        }

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }
        //methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
