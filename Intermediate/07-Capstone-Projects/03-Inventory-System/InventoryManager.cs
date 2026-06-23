using System;
using System.Collections.Generic;


namespace Inventory_System
{
    public class InventoryManager
    {
        private Dictionary<string, Product> _products = new();

        public void AddProduct(Product product)
        {
            if (product is null) throw new ArgumentException("Product cannot be null");

            if (_products.ContainsKey(product.ProductID))
            {
                throw new ArgumentException("Product already exist in the inventory");
            }

            _products.Add(product.ProductID, product);

        }

        public bool DeleteProduct(string productId)
        {
            UtilityClass.ValidateProductId(productId);

            return _products.Remove(productId);
        }

        public Product? SearchProduct(string productId)
        {
            UtilityClass.ValidateProductId(productId);

            if (_products.TryGetValue(productId, out var product))
            {
                return product;
            }

            return null;
        }

        public decimal SellProduct(string productId, int quantity)
        {
            decimal price = 0;

            var product = SearchProduct(productId);

            if (product is null)
            {
                throw new ArgumentException($"No product exist with ID {productId}");
            }

            product.Sell(quantity);

            price = product.Price * quantity;
            return price;
        }

        public void RestockProduct(string productId, int quantity)
        {
            var product = SearchProduct(productId);

            if (product is null)
            {
                throw new ArgumentException($"No product exist with ID {productId}");
            }

            product.Restock(quantity);
        }

        public void SaveToFile()
        {
            string filePath = UtilityClass.GetFilePath();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in _products.Values)
                {
                    writer.WriteLine($"{item.ProductID}|{item.Name}|{item.Price}|{item.Quantity}");
                }
            }
        }

        public void LoadFromFile()
        {
            string filePath = UtilityClass.GetFilePath();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File does`nt exist");
            }

            // Erase the working collection
            _products.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");

                    Product product = new Product(parts[0], parts[1], decimal.Parse(parts[2]), int.Parse(parts[3]));

                    _products.Add(product.ProductID, product);
                }
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.Values
                .OrderBy(x => x.ProductID);
        }

        public IEnumerable<Product> GetLowStockProducts()
        {
            return _products.Values
                .Where(x => x.Quantity < 5)
                .OrderBy(x => x.ProductID);
        }
    }
}