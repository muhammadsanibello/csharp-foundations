using System;

namespace Inventory_Manger
{
    public class Inventory
    {
        // Class property
        private Product[] listOfProducts;
        private int ProductCounter;

        // Constructor
        public Inventory()
        {
            listOfProducts = new Product[1000];
            ProductCounter = 0;
        }

        // Method to add products to the inventory
        public void AddProduct(Product product)
        {
            if (ProductCounter < 1000)
            {
                listOfProducts[ProductCounter] = product;
                ProductCounter++;
            }
            else
            {
                Console.WriteLine("No more space for new product");
            }
        }


        // Method to remove the product from the inventory
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < ProductCounter; i++)
            {
                if (listOfProducts[i] == product)
                {
                    // Shift everything left by one
                    for (int j = i; j < ProductCounter - 1; j++)
                    {
                        listOfProducts[j] = listOfProducts[j + 1];
                    }

                    // Clear the last slot
                    listOfProducts[ProductCounter - 1] = null;

                    // Update the counter
                    ProductCounter--;

                    break; // stop after removing
                }
            }
        }

        // Method to search for a target product
        public Product FindProduct(string productName)
        {
            for (int i = 0; i < ProductCounter; i++)
            {
                // Compare the target product with the list of products
                // in the inventory and ignore the ordinal case.
                if (string.Equals(listOfProducts[i].Name, productName, StringComparison.OrdinalIgnoreCase))
                {
                    return listOfProducts[i];
                }
            }

            return null;  // return empty if target product is not in the inventory.
 
        }

        // Method to display products to customers.
        public void DisplayProducts()
        {
            for (int i = 0; i < ProductCounter; i++)
            {
                Console.Write("Product Name: ");
                Console.WriteLine(listOfProducts[i].Name);
                Console.Write("Product Price: ");
                Console.WriteLine(listOfProducts[i].Price);
                Console.Write("Product Stock: ");
                Console.WriteLine(listOfProducts[i].Stock);

                Console.WriteLine();
            }
        }

        // Method to Sale product to a customer
        public decimal  SaleProduct(string productName, int quantity)
        {
            decimal price = 0;

            // Search for a product
            Product result = FindProduct(productName);

            if (result == null)
            {
                Console.WriteLine("Sorry! This product is not available in our inventory.");
            }
            else
            {
                    result.ReduceStock(quantity);
                    price = result.Price * quantity;
            }
           
            return price;
        }

    }
}
