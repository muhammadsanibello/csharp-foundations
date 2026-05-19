using EmployeeSalarySystem;

// Employee objects
var employee1 = new Employee("Sani Bello", 2000000, 500000);
var employee2 = new Employee("Usman Musa", 3000000, 700000);

employee1.DisplayInfo();
employee1.CalculateSalary();
employee1.DisplaySalarySlip();

Console.WriteLine();

employee2.DisplayInfo();
employee2.CalculateSalary();
employee2.DisplaySalarySlip();