namespace AddressBookSystem
{
    public class AddressBookMainUC5
    {
        static char choice = 'y';
        static int index = 0;
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            List<MultipleContactUC5> contacts = new List<MultipleContactUC5>();
            //Calling method to take input
            while (choice == 'y' || choice == 'Y')
            {
                contacts.Add(new MultipleContactUC5());
                contacts[index].GetDetail();

                Console.Write("Do you want to add more press 'y' or Press any key to Exit = ");
                choice = Convert.ToChar(Console.ReadLine());
                ++index;
            }
        }
    }
}