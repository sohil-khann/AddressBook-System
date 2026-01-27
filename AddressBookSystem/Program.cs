// See https://aka.ms/new-console-template for more information
namespace AddressBookSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System!");

        Console.WriteLine("Add Contact to Address Book:");
        ManageContacts manageContacts = new ManageContacts();
        manageContacts.Addcontact();
        manageContacts.EditContact();
        manageContacts.DeleteContact();

        Console.ReadLine();
    }
}