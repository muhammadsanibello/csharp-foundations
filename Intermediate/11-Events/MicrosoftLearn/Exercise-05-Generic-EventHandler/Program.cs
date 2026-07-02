public class OrderEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
}

public class OrderProcessor
{
    // Using EventHandler<T> to define an event with custom event data
    // Nullable to indicate no subscribers initially
    public event EventHandler<OrderEventArgs>? OrderProcessed;

    protected virtual void OnOrderProcessed(OrderEventArgs e)
    {
        OrderProcessed?.Invoke(this, e);
    }

    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"Processing order {orderId}...");

        OnOrderProcessed(new OrderEventArgs
        {
            OrderId = orderId,
            OrderDate = DateTime.Now
        });
    }
}

public class Program
{
    static void Main()
    {
        // Subscribing to the event
        var orderProcessor = new OrderProcessor();
        orderProcessor.OrderProcessed += (sender, e) =>
        {
            Console.WriteLine($"Order {e.OrderId} processed on {e.OrderDate}");
        };

        orderProcessor.OrderProcessed += (sender, e) =>
        {
            Console.WriteLine($"Order {e.OrderId} processed on {e.OrderDate}");
        };

        orderProcessor.ProcessOrder(123);
        orderProcessor.ProcessOrder(123);
    }
}