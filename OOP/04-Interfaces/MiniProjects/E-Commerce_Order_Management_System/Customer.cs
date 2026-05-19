using System;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Order_Management_System
{
    public class Customer
    {
        // Properties
        private static int s_nextCustomerId;

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string CustomerId { get; }

        // Static constructor
        static Customer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        // Instance constructor
        public Customer(string fullName, string email)
        {
            if (string.IsNullOrWhiteSpace(fullName)) throw new ArgumentNullException(nameof(fullName), "Cannot be empty");

            CustomerId = (s_nextCustomerId++).ToString("D10");
            FullName = fullName;
            Email = email;
        }

        // Method to display customer information
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer details:\nCustomer ID: {CustomerId}\nCustomer Name: {FullName}\nEmail Address: {Email}");
            Console.WriteLine();
        }
    }
}
