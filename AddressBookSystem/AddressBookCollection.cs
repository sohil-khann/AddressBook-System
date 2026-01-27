using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBookCollection
    {
        private Dictionary<string, ManageContacts> addressBooks;

        public AddressBookCollection()
        {
            addressBooks = new Dictionary<string, ManageContacts>();
        }

        public bool AddAddressBook(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Address Book name cannot be empty.");
                return false;
            }

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("An Address Book with this name already exists.");
                return false;
            }

            addressBooks.Add(name, new ManageContacts());
            return true;
        }

        public ManageContacts? GetAddressBook(string name)
        {
            if (addressBooks.TryGetValue(name, out var addressBook))
            {
                return addressBook;
            }
            return null;
        }

        public IEnumerable<string> GetAddressBookNames()
        {
            return addressBooks.Keys;
        }

        public int Count => addressBooks.Count;
    }
}
