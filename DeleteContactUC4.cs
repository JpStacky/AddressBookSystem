using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class DeleteContactUC4
    {
        private string first_Name;
        private string last_Name;
        private string state;
        private string city;
        private int pincode;
        private long phone_Nmuber;
        private string email;

        public void GetDetail()
        {
            Console.Write("Enter First Name = ");
            first_Name = Console.ReadLine();
            Console.Write("Enter Last Name = ");
            last_Name = Console.ReadLine();
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
        public void ViewDetail()
        {
            Console.Write("First Name = " + first_Name);
            Console.Write("Last Name = " + last_Name);
            Console.Write("State = " + state);
            Console.Write("City = " + city);
            Console.Write("Pincode = " + pincode);
            Console.Write("Phone Number = " + phone_Nmuber);
            Console.Write("E-Mail = " + email);
        }
        public void EdiDetail()
        {
            Console.Write("Enter First Name = ");
            first_Name = Console.ReadLine();
            Console.Write("Enter Last Name = ");
            last_Name = Console.ReadLine();
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

            Console.WriteLine("Edit Saved.");
        }
        public int FindContact(string search_Name)
        {
            if (first_Name.Equals(search_Name))
                return 1;
            else
                return 0;
        }
    }
}
