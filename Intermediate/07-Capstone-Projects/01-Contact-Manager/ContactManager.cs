using System;
using System.Collections.Generic;

namespace Contact_Manager
{
    public class ContactManager
    {
        private Dictionary<string, Contact> _listOfContacts = new();

        public void AddContact(Contact contact)
        {
            if (contact is null) throw new ArgumentNullException(nameof(contact), "Cannot be null");

            _listOfContacts.Add(contact.Name, contact);
        }

        public bool DeleteContact(string name)
        {
            return _listOfContacts.Remove(name);
        }

        public Contact SearchContact(string name)
        {
            if (_listOfContacts.TryGetValue(name, out var contact))
            {
                return contact;
            }
            else
            {
                return null;
            }
        }

        public void DisplayContacts()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---- CONTACTS ----\n");

            if (_listOfContacts.Count == 0)
            {
                Console.WriteLine("No contact available");
                return;
            }

            foreach (var contact in _listOfContacts.Values)
            {
                Console.WriteLine(contact);
            }
        }

        public void SaveToFile()
        {

            string filePath = UtilityClass.GetFilePath();

            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (var contact in _listOfContacts.Values)
                {
                    writer.WriteLine(contact);
                }
            }

        }

        public void LoadFromFile()
        {

            string filePath = UtilityClass.GetFilePath();

            if (!Path.Exists(filePath))
            {
                Console.WriteLine("File doesn`t exist");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("File contents:");

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}