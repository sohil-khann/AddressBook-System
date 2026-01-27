using System;
using System.Collections.Generic; 
namespace AddressBookSystem
{
    
    public class ManageContacts
    {
         List<Contact> contacts=new List<Contact>();
         
        //method to add contact
        public void Addcontact()

        {
            Console.WriteLine("Enter First Name:");
            string firstname = Console.ReadLine() ?? "";

            Console.WriteLine("Enter Last Name:");
            string lastname = Console.ReadLine() ?? "";

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine() ?? "";
            Console.WriteLine("Enter City:");
            string city = Console.ReadLine() ?? "";
            Console.WriteLine("Enter State:");
            string state = Console.ReadLine() ?? "";
            Console.WriteLine("Enter Zip:");
            int zip = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter Phone Number:");
            int phoneNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine() ?? "";
            Contact newContact = new Contact(firstname, lastname, address, city, state, zip, phoneNumber, email);

            contacts.Add(newContact);
            Console.WriteLine("Contact added successfully.");
            contacts.ForEach(c => Console.WriteLine(c.ToString()));
        }

        /*Ability to edit
existing contact
person using their
name - Use Console to edit person details*/
        public void EditContact()
        {
            Console.WriteLine("Enter the First Name of the person you want to edit:");
            string name = Console.ReadLine() ?? "";
            bool found = false;

            foreach (var contact in contacts)
            {
                if (contact.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    Console.WriteLine("Contact found. What do you want to edit?");
                    Console.WriteLine("1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. Zip\n7. Phone Number\n8. Email\n9. Edit All");
                    string choice = Console.ReadLine() ?? "";

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter New First Name:");
                            string? fn = Console.ReadLine();
                            contact.FirstName = !string.IsNullOrEmpty(fn) ? fn : contact.FirstName;
                            break;
                        case "2":
                            Console.WriteLine("Enter New Last Name:");
                            string? ln = Console.ReadLine();
                            contact.LastName = !string.IsNullOrEmpty(ln) ? ln : contact.LastName;
                            break;
                        case "3":
                            Console.WriteLine("Enter New Address:");
                            string? ad = Console.ReadLine();
                            contact.Address = !string.IsNullOrEmpty(ad) ? ad : contact.Address;
                            break;
                        case "4":
                            Console.WriteLine("Enter New City:");
                            string? ci = Console.ReadLine();
                            contact.City = !string.IsNullOrEmpty(ci) ? ci : contact.City;
                            break;
                        case "5":
                            Console.WriteLine("Enter New State:");
                            string? st = Console.ReadLine();
                            contact.State = !string.IsNullOrEmpty(st) ? st : contact.State;
                            break;
                        case "6":
                            Console.WriteLine("Enter New Zip:");
                            string? zipInput = Console.ReadLine();
                            contact.Zip = !string.IsNullOrEmpty(zipInput) ? int.Parse(zipInput) : contact.Zip;
                            break;
                        case "7":
                            Console.WriteLine("Enter New Phone Number:");
                            string? phoneInput = Console.ReadLine();
                            contact.PhoneNumber = !string.IsNullOrEmpty(phoneInput) ? int.Parse(phoneInput) : contact.PhoneNumber;
                            break;
                        case "8":
                            Console.WriteLine("Enter New Email:");
                            string? em = Console.ReadLine();
                            contact.Email = !string.IsNullOrEmpty(em) ? em : contact.Email;
                            break;
                        case "9":
                            Console.WriteLine("Enter New First Name:");
                            string? fName = Console.ReadLine();
                            contact.FirstName = !string.IsNullOrEmpty(fName) ? fName : contact.FirstName;
                            Console.WriteLine("Enter New Last Name:");
                            string? lName = Console.ReadLine();
                            contact.LastName = !string.IsNullOrEmpty(lName) ? lName : contact.LastName;
                            Console.WriteLine("Enter New Address:");
                            string? addr = Console.ReadLine();
                            contact.Address = !string.IsNullOrEmpty(addr) ? addr : contact.Address;
                            Console.WriteLine("Enter New City:");
                            string? cityNm = Console.ReadLine();
                            contact.City = !string.IsNullOrEmpty(cityNm) ? cityNm : contact.City;
                            Console.WriteLine("Enter New State:");
                            string? stateNm = Console.ReadLine();
                            contact.State = !string.IsNullOrEmpty(stateNm) ? stateNm : contact.State;
                            Console.WriteLine("Enter New Zip:");
                            string? zInput = Console.ReadLine();
                            contact.Zip = !string.IsNullOrEmpty(zInput) ? int.Parse(zInput) : contact.Zip;
                            Console.WriteLine("Enter New Phone Number:");
                            string? pInput = Console.ReadLine();
                            contact.PhoneNumber = !string.IsNullOrEmpty(pInput) ? int.Parse(pInput) : contact.PhoneNumber;
                            Console.WriteLine("Enter New Email:");
                            string? eMail = Console.ReadLine();
                            contact.Email = !string.IsNullOrEmpty(eMail) ? eMail : contact.Email;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    Console.WriteLine("Contact updated successfully.");
                    Console.WriteLine(contact.ToString());
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }

    }
}