using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class FindPersonByCityStateUC8
    {
        List<ContactBookUC8> contacts = new List<ContactBookUC8>();
        public void CreateContactBook(int i)
        {
            if (i == 1)
            {
                contacts.Add(new ContactBookUC8("Prakash", "Sahu", "Odisha", "Bbsr", 754100, 7865428475, "prakash@gmail.com"));
                contacts.Add(new ContactBookUC8("Rakesh", "Sahu", "Bihar", "Ctc", 452398, 78657868765, "dfgfg@gmail.com"));
                contacts.Add(new ContactBookUC8("Ram", "Sahu", "Up", "Btq", 468367, 656787687, "sfgd@gmail.com"));
                contacts.Add(new ContactBookUC8("Prakash", "Das", "Rajasthan", "Btq", 472869, 1234567854, "sdfsdf@gmail.com"));
                contacts.Add(new ContactBookUC8("Sachin", "Dabhade", "Kerla", "Dhk", 368293, 098764257, "sdfsd@gmail.com"));
                contacts.Add(new ContactBookUC8("Milan", "Sahu", "Odisha", "Ctc", 529043, 6543678953, "zcsd@gmail.com"));
                contacts.Add(new ContactBookUC8("Mohan", "Sahu", "Odisha", "Btq", 123456, 8765324578, "wrwr@gmail.com"));
            }
            else
            {
                contacts.Add(new ContactBookUC8("Prakash", "Sahu", "Odisha", "Bbsr", 754100, 7865428475, "prakash@gmail.com"));
                contacts.Add(new ContactBookUC8("Rakesh", "Sahu", "Bihar", "Ctc", 452398, 78657868765, "dfgfg@gmail.com"));
                contacts.Add(new ContactBookUC8("Ram", "Sahu", "Up", "Btq", 468367, 656787687, "sfgd@gmail.com"));
                contacts.Add(new ContactBookUC8("Prakash", "Das", "Rajasthan", "Btq", 472869, 1234567854, "sdfsdf@gmail.com"));
                contacts.Add(new ContactBookUC8("Sachin", "Dabhade", "Kerla", "Dhk", 368293, 098764257, "sdfsd@gmail.com"));
                contacts.Add(new ContactBookUC8("Milan", "Sahu", "Odisha", "Ctc", 529043, 6543678953, "zcsd@gmail.com"));
                contacts.Add(new ContactBookUC8("Mohan", "Sahu", "Odisha", "Btq", 123456, 8765324578, "wrwr@gmail.com"));
            }
        }
        public void DisplayContact(int i,string state, string city)
        {
            Console.WriteLine("Displaying from Book "+i);
            for (i = 0; i < 7; i++)
                if (state == contacts[i].state || city == contacts[i].city)
                    Console.WriteLine("First Name = {0}\nLast Name = {1}\nState = {2}\nCity = {3}\nPin Code = {4}\nPhone Number = {5}\nEmail  = {6}",
                                        contacts[i].first_Name, contacts[i].last_Name, contacts[i].state, contacts[i].city, contacts[i].pincode, contacts[i].phone_Nmuber, contacts[i].email);
        }
        
    }
}
