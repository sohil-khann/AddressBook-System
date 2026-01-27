using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System!");

        AddressBookCollection collection = new AddressBookCollection();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- System Menu ---");
            Console.WriteLine("1. Create New Address Book");
            Console.WriteLine("2. Select/Switch Address Book");
            Console.WriteLine("3. List All Address Books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a unique name for the new Address Book: ");
                    string name = Console.ReadLine() ?? "";
                    if (collection.AddAddressBook(name))
                    {
                        Console.WriteLine($"Address Book '{name}' created successfully.");
                    }
                    break;

                case "2":
                    Console.Write("Enter the name of the Address Book to select: ");
                    string selectedName = Console.ReadLine() ?? "";
                    ManageContacts? selectedBook = collection.GetAddressBook(selectedName);
                    if (selectedBook != null)
                    {
                        HandleAddressBook(selectedName, selectedBook);
                    }
                    else
                    {
                        Console.WriteLine("Address Book not found.");
                    }
                    break;

                case "3":
                    var bookNames = collection.GetAddressBookNames();
                    if (!bookNames.Any())
                    {
                        Console.WriteLine("No Address Books available.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Available Address Books ---");
                        foreach (var bookName in bookNames)
                        {
                            Console.WriteLine("- " + bookName);
                        }
                    }
                    break;

                case "4":
                    exit = true;
                    Console.WriteLine("Exiting System. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void HandleAddressBook(string bookName, ManageContacts manageContacts)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine($"\n--- Managing Address Book: {bookName} ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display All Contacts");
            Console.WriteLine("5. Back to System Menu");
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
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}