using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class ContactBookUC8
    {
        public string first_Name;
        public string last_Name;
        public string state;
        public string city;
        public int pincode;
        public long phone_Nmuber;
        public string email;

        public ContactBookUC8(string first_Name, string last_Name, string state, string city, int pincode, long phone_Nmuber, string email)
        {
            this.first_Name = first_Name;
            this.last_Name = last_Name;
            this.state = state;
            this.city = city;
            this.pincode = pincode;
            this.phone_Nmuber = phone_Nmuber;
            this.email = email;
        }
    }
}
