using System;

namespace Contact_Manager
{
    public class Contact
    {
        public string Name { get; private set; }
        public PhoneNumber PhoneNumber { get; }
        public Email Email { get; }

        public Contact(string name, PhoneNumber phoneNumber, Email email)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Cannot be null");

            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPhone Number: {PhoneNumber}\nEmail Address: {Email}";
        }
    }
}