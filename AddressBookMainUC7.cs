namespace AddressBookSystem
{
    public class AddressBookMainUC7
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book Program.");
            EliminateDuplicateNameUC7 addressbook = new EliminateDuplicateNameUC7();
            addressbook.CreateContactBook();
        }
    }
}
