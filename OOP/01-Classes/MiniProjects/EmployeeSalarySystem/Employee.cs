using System;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeSalarySystem
{
    public class Employee
    {

        public string Name;
        public double BasicSalary;
        public double Bonus;
        public double TotalSalary;

        public Employee(string employeeName, double basicSalary, double bonus)
        {
            Name = employeeName;
            BasicSalary = basicSalary;
            Bonus = bonus;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($" Employee:\n Name:\t {Name}\n Baic Salary: {BasicSalary}\n Bonus:\t {Bonus}");
        }

        public void CalculateSalary()
        {
            TotalSalary = BasicSalary + Bonus;
        }

        public void DisplaySalarySlip()
        {
            Console.WriteLine($"Total Salary: {TotalSalary}");
        }
    }

}
