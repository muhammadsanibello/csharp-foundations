// Composite Formatting (e.g Format() method)

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", second, first);
Console.WriteLine("{0} {0} {0}!", first, second);
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result);

// Using string interpolation

Console.WriteLine("");
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}");

// Formatting Currency (e.g C format specifier)

Console.WriteLine("");
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (save {discount:C})");

// Formatting Numbers (e.g N format specifier)

Console.WriteLine("");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatting Percentage (e.g P format specifier)

Console.WriteLine("");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}");

// Combining formatting approaches

Console.WriteLine("");
decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = ($"You saved {price1 - salePrice:C} off the regular {price1:C} prices.");
yourDiscount += $"A discount of {((price1 - salePrice) / price1):P}";
Console.WriteLine(yourDiscount);