// Expression Body Definitions

public class Car
{
    public string modelName;

    // Constructor
    public Car(string model) => modelName = model;
}

public class Employee
{
    public int salary;

    public Employee() {}

    public Employee(int annualSalary) => salary = annualSalary;

    public Employee(int weeklySalary, int numberOfWeeks) => salary = weeklySalary * numberOfWeeks;
}

static class Program
{
    static void Main()
    {
        var car1 = new Car("406");
        var employee1 = new Employee();
        var employee2 = new Employee(200000);
        var employee3 = new Employee(10000, 52);

        Console.WriteLine($"Model Name: {car1.modelName}");
        Console.WriteLine($"Employee 1: {employee1.salary}");
        Console.WriteLine($"Employee 2: {employee2.salary}");
        Console.WriteLine($"Employee 3: {employee3.salary}");
    }
}