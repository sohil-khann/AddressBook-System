using System;
using System.Collections.Generic; 
namespace AddressBookSystem
{
    
    public class ManageContacts
    {
        Contact contact;
         List<Contact> contacts=new List<Contact>();
         
        //method to add contact
        public void Addcontact()

        {
            Console.WriteLine("Enter First Name:");
            string firstname=Console.ReadLine()??"";

            Console.WriteLine("Enter Last Name:");
            string lastname=Console.ReadLine()??"";

            Console.WriteLine("Enter Address:");
            string address=Console.ReadLine()??"";
            Console.WriteLine("Enter City:");
            string city=Console.ReadLine()??"";
            Console.WriteLine("Enter State:");
            string state=Console.ReadLine()??"";
            Console.WriteLine("Enter Zip:");
            int zip=int.Parse(Console.ReadLine()??"0");
            Console.WriteLine("Enter Phone Number:");   
            int phoneNumber=int.Parse(Console.ReadLine()??"0");

            Console.WriteLine("Enter Email:");
            string email=Console.ReadLine()??"";
             contact=new Contact(firstname,lastname,address,city,state,zip,phoneNumber,email);

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
            contacts.ForEach(contact => Console.WriteLine(contact.ToString())); 
        }
    }
}