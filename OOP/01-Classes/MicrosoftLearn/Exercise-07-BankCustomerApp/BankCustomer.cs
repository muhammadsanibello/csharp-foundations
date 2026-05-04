using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_07_BankCustomerApp
{
    public class BankCustomer
    {
        private static int s_nextCustomerId;
        public string FirstName = "Sani";
        public string LastName = "Bello";
        public readonly string CustomerId;

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer()
        {
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

        public BankCustomer(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

    }
}