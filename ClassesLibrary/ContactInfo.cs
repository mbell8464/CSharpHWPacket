using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        //properties
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }

        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //constructors
        //default
        public ContactInfo()
        {

        }

        //FQ
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"Street Address: {StreetAddress}\nCity: {City}\nState: {State}\nPhone Number: {Phone}\nEmail: {Email}\n");
        }
    }
}
