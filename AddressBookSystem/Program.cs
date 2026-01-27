// See https://aka.ms/new-console-template for more information
namespace AddressBookSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System!");

        ManageContacts manageContacts = new ManageContacts();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Address Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display All Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    manageContacts.Addcontact();
                    break;
                case "2":
                    manageContacts.EditContact();
                    break;
                case "3":
                    manageContacts.DeleteContact();
                    break;
                case "4":
                    manageContacts.DisplayContacts();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting Address Book System. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}