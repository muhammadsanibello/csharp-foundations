// Inventor Management System

using Inventory_Manger;

try
{
    // Product objects
    var product1 = new Product("Laptop", 200000, 20);
    var product2 = new Product("Phone", 150000, 40);
    var product3 = new Product("Watch", 50000, 50);
    var product4 = new Product("Headphone", 5000, 100);
    var product5 = new Product("PowerBank", 15000, 70);

    // Inventory object
    var inventory = new Inventory();

    // Add product to inventory
    inventory.AddProduct(product1);
    inventory.AddProduct(product2);
    inventory.AddProduct(product3);
    inventory.AddProduct(product4);

    // Display Products
    inventory.DisplayProducts();

    // Remove product
    inventory.RemoveProduct(product1);

    // Display product
    Console.WriteLine("Updated inventory:");
    inventory.DisplayProducts();

    // Search a product
    Console.WriteLine("Searched Product");
    Product result = inventory.FindProduct("laptop");

    if (result == null)
    {
        Console.WriteLine("No product found.");
    }
    else
    {
        result.DisplayInfo();
    }

    Console.WriteLine();

    // Sale a product
    string product = "phone";
    int quantity = 20;
    decimal price = inventory.SaleProduct(product, quantity);

    if (price == 0)
    {
        Console.WriteLine("Purchase failed");
    }
    else
    {
        Console.WriteLine("Success! You purchased {0} {1} at N{2:F2}.", quantity, product, price);
    }

    // Test for the remaining phone product
    product2.DisplayInfo();

    // increase stocks to a Phone product
    product2.IncreaseStock(20);
    product2.DisplayInfo();

    // Reduce stock of product2
    product2.ReduceStock(50);
    product2.DisplayInfo();

}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}