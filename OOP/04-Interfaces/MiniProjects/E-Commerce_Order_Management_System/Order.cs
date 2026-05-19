using System;

namespace E_Commerce_Order_Management_System
{
    public abstract class Order
    {
        // Properties
        private static int s_nextOrderId;
        public string OrderId { get; }
        public Customer customer { get; private set; }
        public Product product { get; private set; }
        public int TotalAmount { get; private set; }
        public IPaymentMethod PaymentMethod { get; private set; }
        public IShippingService ShippingService { get; private set; }

        // Static constructor
        static Order()
        {
            Random random = new Random();
            s_nextOrderId = random.Next(10000000, 20000000);
        }

        // Instance constructor
        public Order(Customer customer, Product product, int totalAmount, IPaymentMethod paymentMethod, IShippingService shippingService)
        {
            if (totalAmount <= 0) throw new ArgumentException(nameof(totalAmount), "Must be greater than zero");

            OrderId = (s_nextOrderId++).ToString("D10");
            this.customer = customer;
            this.product = product;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
            ShippingService = shippingService;
        }

        // Method to calculate total
        public decimal CalculateTotal()
        {
            return product.Price * TotalAmount;
        }
            
        // Method to display order summary
        public void DisplayOrderSummary()
        {
            Console.WriteLine($"Order Summary:\nOrder ID: {OrderId}\nCustomer Name: {customer.FullName}\nProduct Name: {product.ProductName}\nAmount purchase: {TotalAmount}");
            Console.WriteLine();
        }

        // Method to process order
        public abstract void ProcessOrder();

    }
}
