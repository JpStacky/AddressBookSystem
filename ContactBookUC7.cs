using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class ContactBookUC7
    {
        private string first_Name;
        private string last_Name;
        private string state;
        private string city;
        private int pincode;
        private long phone_Nmuber;
        private string email;

        public string get_first_Name()
        { 
            return first_Name;
        }
        public string get_last_Name()
        { 
            return last_Name;
        }
        public void GetDetail(string first_Name, string last_Name)
        {
            this.first_Name = first_Name;
            this.last_Name = last_Name;
            Console.Write("Enter State Name = ");
            state = Console.ReadLine();
            Console.Write("Enter City Name = ");
            city = Console.ReadLine();
            Console.Write("Enter Pincode = ");
            pincode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number = ");
            phone_Nmuber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter E-Mail = ");
            email = Console.ReadLine();

            Console.WriteLine("Contact Created. Details Saved.");
        }
    }
}
