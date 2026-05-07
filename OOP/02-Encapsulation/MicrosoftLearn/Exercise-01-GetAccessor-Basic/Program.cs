// The get acceccor basic

using System.Globalization;

public class Employee
{
    private string _name;  // the name field
    private double salary = 5000;
    public string Name
    {
        get { return _name != null ? _name : "NA"; }  // the Name property
    }
    public double Salary
    {
        get { return salary; }
    }
}

static class Program
{
    static void Main()
    {
        var employee1 = new Employee();
        Console.WriteLine(employee1.Name);
        Console.WriteLine(employee1.Salary);
    }
}