using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class MultipleAddressBookUC6
    {
        static char choice = 'y';
        static int index = 0;
        List<ContactBookUC6> contacts = new List<ContactBookUC6>();
        public void CreateContactBook()
        {
            while (choice == 'y' || choice == 'Y')
            {
                contacts.Add(new ContactBookUC6());
                contacts[index].GetDetail();

                Console.Write("Do you want to add more press 'y' or Press any key to Exit = ");
                choice = Convert.ToChar(Console.ReadLine());
                ++index;
            }
        }
    }
}
