interface ICustomer
{
    int CustomerId { get; set; }

    void ApplyLoyaltyDiscount()
    {
        // default implementation
        Console.WriteLine("Applying 10% loyalty discount.");
    }
}

// Implementing an interface
public class VIPCustomer : ICustomer
{
    public int CustomerId { get; set; } // Implementing property from interface

    void ICustomer.ApplyLoyaltyDiscount()
    {
        // override default implementation for VIP customers
        Console.WriteLine($"Applying 20% loyalty discount for VIP customers with ID {CustomerId}");
    }
}