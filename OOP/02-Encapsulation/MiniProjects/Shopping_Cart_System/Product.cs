using System;

namespace Shopping_Cart_System
{
    public class Product
    {

        // Properties
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; set; }

        // Constructor
        public Product(string name, decimal price, int stock)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }

            if (price < 0 || stock < 0)
            {
                Console.WriteLine("Price or Stock can't be negative");
                return;
            }

            Name = name;
            Price = price;
            Stock = stock;
        }

    }
}