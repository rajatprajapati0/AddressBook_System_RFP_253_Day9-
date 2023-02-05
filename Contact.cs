using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string Address;
        public string City;
        public string State;
        public string Zipcode;
        public string Phone;
        public string Email;

        public override string ToString()
        {
        return @$"
          Name: {firstName} {lastName}
          Address: {this.Address} 
          City: {this.City}
          State: {this.State}
          Zipcode: {this.Zipcode}
          PhoneNumber:{this.Phone}
          Email: {this.Email}
                   ";
        }
    }
}
