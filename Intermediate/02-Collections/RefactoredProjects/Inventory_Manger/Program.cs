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
    inventory.AddProduct(product5);

    // Display Products
    inventory.DisplayProducts();

    // Remove product
    bool removalSuccess = inventory.RemoveProduct("laptop");

    if (!removalSuccess)
    {
        Console.WriteLine("This product is not available in the inventory");
    }

    // Display remaining products
    inventory.DisplayProducts();

    // Search a product
    Console.WriteLine("Searching a Product");
    Product product = inventory.FindProduct("phone");

    if (product == null)
    {
        Console.WriteLine("No product found.");
    }
    else
    {
        product.DisplayInfo();
    }

    // Sale a product
    string productName = "Phone";
    int quantity = 30;

    decimal price = inventory.SellProduct(productName, quantity);

    if (price == 0)
    {
        Console.WriteLine("Product is not available in the inventory.");
    }
    else
    {
        Console.WriteLine("Success! You purchased {0} {1} at N{2:F2}.", quantity, productName, price);
    }

    // Test for the remaining phone product
    product2.DisplayInfo();

    inventory.DisplayProducts();

}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}