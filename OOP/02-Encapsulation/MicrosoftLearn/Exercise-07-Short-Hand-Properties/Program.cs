// This class is mutable. Its data can be modified from
// outside the class.
public class Customer
{
    // Auto-implemented properties for trivial get and set
    public double TotalPurchase { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set; }

    // Constructor
    public Customer(double totalPurchase, string name, int id)
    {
        TotalPurchase = totalPurchase;
        Name = name;
        CustomerId = id;
    }

    // Methods
    public string GetContactInfo() { return "ContactInfo"; }
    public string GetTransactionHistory() { return "History"; }

    // .. Other methods, events, etc.

}

class Program
{
    static void Main()
    {
        // Initialize a new object.
        var cust1 = new Customer(4987.63, "Northwind", 90108);

        // Modify a property.
        cust1.TotalPurchase += 499.99;
        Console.WriteLine(cust1.TotalPurchase);
    }
}

// Profile class
public class Profile
{
    public string FirstName
    {
        get;
        set
        {
            field = (string.IsNullOrWhiteSpace(value) is false
                ? value
                : throw new ArgumentException(nameof(value), "First name can\'t be whitespace or null"));
        }
    } = "FirstName";
}