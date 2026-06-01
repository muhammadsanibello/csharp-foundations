enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}

class Order
{
    public int OrderID { get; set; }
    public OrderStatus Status { get; set; }

    public void UpdateStatus(OrderStatus newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Order {OrderID} status updated to {Status}");
    }
}

class Program
{
    static void Main()
    {
        var order = new Order { OrderID = 123, Status = OrderStatus.Pending };
        order.UpdateStatus(OrderStatus.Shipped);
        Console.WriteLine(order.Status);
    }
}