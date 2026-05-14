using System;

namespace School_Management_System
{
    public abstract class Person
    {
        private static int s_nextID;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string ID { get; }

        static Person()
        {
            Random random = new Random();
            s_nextID = random.Next(10000000, 20000000);
        }

        public Person(string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName), "Cannot be empty.");

            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName), "Cannot be empty.");

            if (age <= 0) throw new ArgumentException(nameof(age), "Must be greater than zero.");

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = (s_nextID++).ToString("D10");

        }

        public abstract void DisplayInfo();
    }
}
