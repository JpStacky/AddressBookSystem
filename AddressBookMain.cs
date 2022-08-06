namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");

            //Calling method to take input
            ContactUC1 contact = new ContactUC1();
            contact.GetDetail();
        }
    }
}