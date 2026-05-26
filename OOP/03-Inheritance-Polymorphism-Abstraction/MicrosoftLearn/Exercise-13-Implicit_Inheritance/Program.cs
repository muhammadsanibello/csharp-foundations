public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

}

public class Employee : Person
{
    public int EmployeeNumber { get; set; }
    public decimal Salary { get; set; }

}

class Program
{
    static void Main()
    {
        Person person1 = new Person { Name = "Alice", Age = 30 };
        Person person2 = new Person { Name = "Alice", Age = 30 };
        Person person3 = person1;

        Console.WriteLine(person1.ToString());
        Console.WriteLine(person1.Equals(person2));
        Console.WriteLine(person1.GetHashCode());
        Console.WriteLine(person1.Equals(person3));
    }
}