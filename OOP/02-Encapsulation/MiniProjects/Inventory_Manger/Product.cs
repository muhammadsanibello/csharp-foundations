using System;
using System.Globalization;

namespace Inventory_Manger
{
    public class Product
    {
        // Class properties
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        // Constructor
        public Product(string name, decimal price, int stock)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name cant\'t be empty");

            if (price < 0)
                throw new ArgumentException("Price can\'t be negative");

            if (stock <= 0)
                throw new ArgumentException("Stock must be greater than zero");

            Name = name;
            Price = price;
            Stock = stock;

        }

        // Methods
        public void ReduceStock(int stockSales)
        {
            if (stockSales <= 0)
            {
                throw new ArgumentException("StockSales must be greater than zero");
            }
            else if (stockSales > Stock)
            {
                throw new ArgumentException("Insufficient stock");
            }

                Stock -= stockSales;
        }

        public void IncreaseStock(int addedStock)
        {
            if (addedStock <= 0)
            {
                throw new ArgumentException("Stock must be greater than zero");
            }
            Stock += addedStock;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Product Name: {0}, Price: {1}, Available Stock: {2}", Name, Price, Stock);
        }
    }
}
