using System;
using System.Collections.Generic;
using System.Text.Json;


namespace Inventory_System
{
    public class InventoryManager
    {
        private Dictionary<string, Product> _products = new();

        public void AddProduct(Product product)
        {
            if (product is null) throw new ArgumentNullException(nameof(product), "Product cannot be null");

            if (_products.ContainsKey(product.ProductID))
            {
                throw new ArgumentException("Product already exist in the inventory");
            }

            _products.Add(product.ProductID, product);

            var args = new ProductEventArgs(product);

            OnProductAdded(args);

        }

        public bool DeleteProduct(string productId)
        {
            UtilityClass.ValidateProductId(productId);

            var product = SearchProduct(productId);

            if (product is null)
            {
                return false;
            }

            _products.Remove(productId);

            var args = new ProductEventArgs(product);
            OnProductDeleted(args);

            return true;
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
                throw new ArgumentNullException($"No product exist with ID {productId}");
            }

            product.Sell(quantity);

            price = product.Price * quantity;

            if (product.Quantity <= 5)
            {
                OnLowStockReached(new ProductEventArgs(product));
            }
            return price;
        }

        public void RestockProduct(string productId, int quantity)
        {
            var product = SearchProduct(productId);

            if (product is null)
            {
                throw new ArgumentNullException($"No product exist with ID {productId}");
            }

            product.Restock(quantity);
        }

        public void SaveToFile()
        {
            string filePath = UtilityClass.GetFilePath();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(_products.Values, options);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile()
        {
            string filePath = UtilityClass.GetFilePath();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File does`nt exist");
            }

            var jsonString = File.ReadAllText(filePath);

            var products = JsonSerializer.Deserialize<List<Product>>(jsonString) ?? throw new InvalidOperationException("Failed to deserialize product");

            // Erase the working collection
            _products.Clear();

            foreach (var product in products)
            {
                _products.Add(product.ProductID, product);
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

        // Define Product Added event
        public event EventHandler<ProductEventArgs>? ProductAdded;

        // Define Product deleted event
        public event EventHandler<ProductEventArgs>? ProductDeleted;

        // Define an event for low-stock products
        public event EventHandler<ProductEventArgs>? LowStockReached;

        // Method that raise an event when product added
        protected virtual void OnProductAdded(ProductEventArgs e)
        {
            ProductAdded?.Invoke(this, e);
        }

        // Method that raise an event when product deleted
        protected virtual void OnProductDeleted(ProductEventArgs e)
        {
            ProductDeleted?.Invoke(this, e);
        }

        // Method that raise an event when product low stock level reached
        protected virtual void OnLowStockReached(ProductEventArgs e)
        {
            LowStockReached?.Invoke(this, e);
        }
    }
}