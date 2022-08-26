using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class EliminateDuplicateNameUC7
    {
        static char choice = 'y';
        static int index = 0;
        List<ContactBookUC7> contacts = new List<ContactBookUC7>();
        public void CreateContactBook()
        {
            while (choice == 'y' || choice == 'Y')
            {
                Console.Write("Enter First Name = ");
                string first_Name = Console.ReadLine();
                Console.Write("Enter Last Name = ");
                string last_Name = Console.ReadLine();

                int temp_Index = index;
                if (temp_Index >= 0)
                {
                    if (contacts[temp_Index].get_first_Name() == first_Name && contacts[temp_Index].get_last_Name() == last_Name)
                    {
                        Console.WriteLine("Entry found with same name");
                        break;
                    }
                    --temp_Index;
                }
                contacts.Add(new ContactBookUC7());
                contacts[index].GetDetail();

                Console.Write("Do you want to add more press 'y' or Press any key to Exit = ");
                choice = Convert.ToChar(Console.ReadLine());
                ++index;
            }
        }
    }
}
