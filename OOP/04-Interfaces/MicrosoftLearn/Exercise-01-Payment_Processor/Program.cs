// Interface defining a contract
public interface IPaymentProcessor
{
    void ProcessPayment(double amount);

}

// Class implementing the interface
public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}


// Another example
public interface IPayment
{
    void Pay();
}

public class CashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying with cash");
    }
}

public class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paying with credit card");
    }
}