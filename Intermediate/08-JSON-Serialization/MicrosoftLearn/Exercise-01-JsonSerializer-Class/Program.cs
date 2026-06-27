using System.Text.Json;

class Employee
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
}

class Program
{
    static void Main()
    {
        var customer = new Employee { Name = "Anette Thomsen", Age = 30, Address = "123 Main St" };

        // Serialize
        string jsonString = JsonSerializer.Serialize(customer);
        Console.WriteLine(jsonString);

        // Deserialize
        var customer1 = JsonSerializer.Deserialize<Employee>(jsonString);

        if (customer1 != null)
        {
            Console.WriteLine($"Name: {customer1.Name}, Age: {customer1.Age}, Address: {customer1.Address}");
        }
        else
        {
            Console.WriteLine("Deserialization failed");
        }
    }
}