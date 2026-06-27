using System;

namespace Inventory_System
{
    public class Product
    {
        public string ProductID { get;  }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string productId, string name, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(productId) || !productId.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid ID");

            }
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Invalid name");

            if (price < 0) throw new ArgumentException(nameof(price), "Cannot be negative");

            if (quantity <= 0) throw new ArgumentException(nameof(quantity), "Must be greater than zero");

            ProductID = productId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Method of increasing stock
        public void Restock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException(nameof(quantity), "Must be greater than zero");

            Quantity += quantity;
        }

        // Method to reduce stock
        public void Sell(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException(nameof(quantity), "Must be greater than zero");

            if (quantity > Quantity) throw new ArgumentException(nameof(quantity), "Insufficient stock");

            Quantity -= quantity;
        }

        public override string ToString()
        {
            return $"Product ID: {ProductID}\nProduct Name: {Name}\nProduct Price: {Price}\nAvailable Stock: {Quantity}\n";
        }
    }
}