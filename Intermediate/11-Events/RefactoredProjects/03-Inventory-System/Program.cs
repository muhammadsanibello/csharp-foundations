using Inventory_System;

Console.WriteLine("===== INVENTORY SYSTEM =====");

Console.WriteLine(Environment.NewLine);
Console.WriteLine("1.  Add Product");
Console.WriteLine("2.  View Products");
Console.WriteLine("3.  Search Product");
Console.WriteLine("4.  Delete Product");
Console.WriteLine("5.  Restock Product");
Console.WriteLine("6.  Sell Product");
Console.WriteLine("7.  Save Inventory");
Console.WriteLine("8.  Load Inventory");
Console.WriteLine("9.  Inventory Statistics");
Console.WriteLine("10. Low Stock Products");
Console.WriteLine("0.  Exit");

// Create inventory manager object
InventoryManager manager = new InventoryManager();
manager.ProductAdded += (sender, e) =>
{
    Console.WriteLine($"Product with ID '{e.Product.ProductID}' added to the inventory.");
};
manager.ProductDeleted += (sender, e) =>
{
    Console.WriteLine($"Product with ID '{e.Product.ProductID}' removed from the inventory.");
};
manager.LowStockReached += (sender, e) =>
{
    Console.WriteLine($"Warning!\n{e.Product.Name} {e.Product.Quantity} left");
};

string? input = string.Empty;
bool validInput = false;

do
{
    Console.WriteLine(Environment.NewLine);
    Console.Write("Choose one of the above options: ");

    // Prompt the user for option
    input = Console.ReadLine() ?? "";

    validInput = UtilityClass.ValidateInput(input);

    if (!validInput)
    {
        Console.WriteLine("Invalid option! Try-again");
        continue;
    }

    try
    {
        switch (input)
        {
            case "1":

                Console.Write("Enter product ID: ");
                input = Console.ReadLine() ?? "";

                UtilityClass.ValidateProductId(input);

                string id = input;

                Console.Write("Enter product name: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid name! Try-again");
                    break;
                }

                string name = input;

                Console.Write("Enter product price: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid price! Try-again");
                    break;
                }

                decimal price = decimal.Parse(input);

                Console.Write("Enter product quantity: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid quantity! Try-again");
                    break;
                }

                int quantity = int.Parse(input);

                manager.AddProduct(new Product(id, name, price, quantity));

                break;

            case "2":

                Console.WriteLine("\n === List of Products === \n");

                if (!manager.GetProducts().Any())
                {
                    Console.WriteLine("No product available");
                    break;
                }

                foreach (var item in manager.GetProducts())
                {
                    Console.WriteLine(item);
                }

                break;

            case "3":

                Console.Write("Enter product ID: ");
                input = Console.ReadLine() ?? "";

                var product = manager.SearchProduct(input);

                if (product is null)
                {
                    Console.WriteLine($"No product exist with ID {input}");
                    break;
                }

                Console.WriteLine("\nProduct found\n");
                Console.WriteLine(product);
                break;

            case "4":

                Console.Write("Enter product ID: ");
                input = Console.ReadLine() ?? "";

                bool deleteSuccess = manager.DeleteProduct(input);

                if (!deleteSuccess)
                {
                    Console.WriteLine($"No product with ID {input} found");
                    break;
                }

                break;

            case "5":

                Console.Write("Enter product ID: ");
                input = Console.ReadLine() ?? "";

                UtilityClass.ValidateProductId(input);

                id = input;

                Console.Write("Enter quantity: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid quantity! Try-again");
                    break;
                }

                manager.RestockProduct(id, int.Parse(input));
                break;

            case "6":

                Console.Write("Enter product ID: ");
                input = Console.ReadLine() ?? "";

                UtilityClass.ValidateProductId(input);

                id = input;

                Console.Write("Enter quantity: ");
                input = Console.ReadLine() ?? "";

                validInput = UtilityClass.ValidateInput(input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid quantity! Try-again");
                    break;
                }

                decimal totalPrice = manager.SellProduct(id, int.Parse(input));

                Console.WriteLine($"Total Price of Sell = {totalPrice}");
                break;

            case "7":

                manager.SaveToFile();
                Console.WriteLine("Inventory saved.");

                break;

            case "8":

                manager.LoadFromFile();
                Console.WriteLine("Loaded inventory successfully");
                break;

            case "9":

                int totalProducts = manager.GetProducts().Count();
                int totalQuantity = manager.GetProducts().Sum(x => x.Quantity);
                decimal totalInventoryValue = manager.GetProducts().Sum(x => x.Price * x.Quantity);

                Console.WriteLine("\n === Inventory Statistics === \n");

                Console.WriteLine($"Total Products:        {totalProducts}");
                Console.WriteLine($"Total Quantity:        {totalQuantity}");
                Console.WriteLine($"Total Inventory Value: {totalInventoryValue:C}");

                break;

            case "10":

                // Display low stock report
                Console.WriteLine("\n ==== Low Stock Alert ==== \n");

                if (!manager.GetLowStockProducts().Any())
                {
                    Console.WriteLine("No product with stock below 5 available");
                    break;
                }

                foreach (var lowProduct in manager.GetLowStockProducts())
                {
                    Console.WriteLine($"{lowProduct.Name} - {lowProduct.Quantity}");
                }

                break;

            default:
                throw new ArgumentException("Option doesn`t exist");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

} while (input != "0");