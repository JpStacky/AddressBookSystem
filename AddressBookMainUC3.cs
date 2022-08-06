namespace AddressBookSystem
{
    public class AddressBookMainUC3
    {
        static char choice = 'y';
        static int index = 0;
        static int option;
        static List<EditContactUC3> contacts = new List<EditContactUC3>();
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            Option();
        }
        public static void Option()
        {
            Console.Write("1. Add Contact \n2. Edit Contact \nSelect your choice = ");
            option = Convert.ToInt32(Console.ReadLine());
            ExecuteOption();
        }
        public static void ExecuteOption()
        {
            if (option == 1)
            {
                while (choice == 'y' || choice == 'Y')
                {
                    contacts.Add(new EditContactUC3());
                    contacts[index].GetDetail();

                    Console.Write("Do you want to add more press 'y' or Press any key to Exit = ");
                    choice = Convert.ToChar(Console.ReadLine());
                    ++index;
                }
            }
            else if (option == 2)
            {
                Console.Write("Enter First Name to find Contact & Edit = ");
                string search_Name = Console.ReadLine();
                int i;
                for (i = 0; i < index; i++)
                {
                    int find = contacts[i].FindContact(search_Name);
                    if (find == 0)
                        continue;
                    else
                    {
                        contacts[i].ViewDetail();
                        break;
                    }
                }
                if (i != index)
                    contacts[i].EdiDetail();
                else
                {
                    Console.WriteLine("No Records Found.");
                    Option();
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                Option();
            }
        }
    }
}
