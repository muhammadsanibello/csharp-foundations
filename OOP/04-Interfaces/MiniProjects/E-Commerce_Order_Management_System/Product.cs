using System;

namespace E_Commerce_Order_Management_System
{
    public class Product
    {
        // Properties
        private static int s_nextProductId;
        
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public string ProductId { get; }

        // Static constructor
        static Product()
        {
            Random random = new Random();
            s_nextProductId = random.Next(10000000, 20000000);
        }

        // Instance constructor
        public Product(string productName, decimal price, int stockQuantity)
        {
            if (string.IsNullOrWhiteSpace(productName)) throw new ArgumentNullException(nameof(productName), "Cannot be empty");

            if (price < 0) throw new ArgumentException(nameof(price), "Cannot be negative");

            if (stockQuantity <= 0) throw new ArgumentException(nameof(stockQuantity), "Must be greater than zero");

            ProductId = (s_nextProductId++).ToString("D10");
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // Method to reduce stock
        public bool ReduceStock(int stock)
        {
            if (StockQuantity - stock < 0)
            {
                return false;
            }

            StockQuantity -= stock;
            return true;
        }

        // Method to display product
        public void DisplayProduct()
        {
            Console.WriteLine($"Product details:\nProduct ID: {ProductId}\nProduct Name: {ProductName}\nProduct Price: {Price}\nAvailable Stocks: {StockQuantity}");
            Console.WriteLine();
        }
    }
}
