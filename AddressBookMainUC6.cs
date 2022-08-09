namespace AddressBookSystem
{
    public class AddressBookMainUC6
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            MultipleAddressBookUC6 addressbook1 = new MultipleAddressBookUC6();
            MultipleAddressBookUC6 addressbook2 = new MultipleAddressBookUC6();
            addressbook1.CreateContactBook();
            addressbook2.CreateContactBook();
        }
    }
}