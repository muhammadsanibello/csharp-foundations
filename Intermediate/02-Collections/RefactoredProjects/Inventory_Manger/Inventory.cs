using System;

namespace Inventory_Manger
{
    public class Inventory
    {
        // Class property
        private Dictionary<string, Product> _products;

        // Constructor
        public Inventory()
        {
            _products = new Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase);
        }

        // Method to add products to the inventory
        public void AddProduct(Product product)
        {
            _products.Add(product.Name, product);
        }


        // Method to remove the product from the inventory
        public bool RemoveProduct(string productName)
        {
            return _products.Remove(productName);
        }

        // Method to search for a target product
        public Product FindProduct(string productName)
        {
            if (_products.TryGetValue(productName, out Product product))
            {
                return product;
            }

                return null;
        }

        // Method to display products to customers.
        public void DisplayProducts()
        {
            Console.WriteLine("Available Inventory Products:\n");

            if (_products.Count == 0)
            {
                Console.WriteLine("No products in the inventory");
                return;
            }

            foreach (var product in _products)
            {
                product.Value.DisplayInfo();
            }
        }

        // Method to Sale product to a customer
        public decimal SellProduct(string productName, int quantity)
        {
            // Search a product in the inventory
            Product foundProduct = FindProduct(productName);

            if (foundProduct == null)
            {
                return 0;
            }

            foundProduct.ReduceStock(quantity);

            // return price
            return foundProduct.Price * quantity;
        }

    }
}