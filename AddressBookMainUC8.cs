using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMainUC8
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            FindPersonByCityStateUC8 addressbook1 = new FindPersonByCityStateUC8();
            FindPersonByCityStateUC8 addressbook2 = new FindPersonByCityStateUC8();
            addressbook1.CreateContactBook(1);
            addressbook2.CreateContactBook(2);
            Console.Write("Enter State Name = ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter City Name = ");
            string city = Console.ReadLine();
            addressbook1.DisplayContact(1,state,city);
            addressbook2.DisplayContact(2,state,city);
        }
    }
}
