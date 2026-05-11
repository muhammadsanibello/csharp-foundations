using System;

namespace Exercise_09_BankingApp
{
    public partial class BankCustomer
    {
        // Method to update the customer's name
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Console.WriteLine("Name updated successfully");
        }

        // Method to return the full name of the customer
        public string ReturnFullName()
        {
            return $"{LastName} {LastName}";
        }

        // Method to display the customer information
        public string DisplayCustomerInfo()
        {
            return $"Customer ID: {CustomerId}, Name {ReturnFullName}";
        }
    }
}
