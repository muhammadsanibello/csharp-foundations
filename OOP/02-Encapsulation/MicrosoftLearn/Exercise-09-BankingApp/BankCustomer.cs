using System;

namespace Exercise_09_BankingApp
{
    public partial class BankCustomer
    {
        private static int s_nextCustomerId;
        private string _firstName = "Sani";
        private string _lastName = "Bello";

        public string CustomerId { get; }
        
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

    }
}