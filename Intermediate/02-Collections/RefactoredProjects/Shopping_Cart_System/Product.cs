using System;

namespace Shopping_Cart_System
{
    public class Product
    {

        // Properties
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        // Constructor
        public Product(string name, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Cannot be empty");

            if (price < 0) throw new ArgumentException(nameof(price), "Cannot be negative");

            if (stock <= 0) throw new ArgumentException(nameof(stock), "Must be greater than zero");
            
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Method for reducing stock
        public void ReduceStock(int quantity)
        {
            if (quantity > 0 && quantity <= Stock)
            {
                Stock -= quantity;
            }
        }

    }
}