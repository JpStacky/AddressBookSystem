namespace AddressBookSystem
{
    public class AddressBookMainUC2
    {
        static char choice = 'y';
        static int index = 0;
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            List<ContactUC1> contacts = new List<ContactUC1>();
            //Calling method to take input
            while (choice == 'y' || choice == 'Y')
            {
                contacts.Add(new ContactUC1());
                contacts[index].GetDetail();

                Console.Write("Do you want to add more press 'y' or Press any key to Exit = ");
                choice = Convert.ToChar(Console.ReadLine());
                ++index;
            }
        }
    }
}