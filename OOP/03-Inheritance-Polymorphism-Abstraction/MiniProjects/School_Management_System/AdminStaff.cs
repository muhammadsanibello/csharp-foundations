using System;

namespace School_Management_System
{
    public class AdminStaff : Person
    {
        public string Role { get; private set; }
        public string DutyName { get; private set; } = "Unknown";
        
        public AdminStaff(string firstName, string lastName, int age, string role) : base(firstName, lastName, age)
        {
            if (string.IsNullOrEmpty(role)) throw new ArgumentNullException(nameof(role), "Cannot be empty");

            Role = role;
        }

        public void AssignDuty(string dutyName)
        {
            DutyName = dutyName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Admin Staff Details:\nFirst Name: {0}\nLast Name: {1}\nAge:   {2}\nAdmin ID: {3}\nRole:  {4}\nDuty Name: {5}", FirstName, LastName, Age, ID, Role, DutyName);
            Console.WriteLine();
        }
    }
}
