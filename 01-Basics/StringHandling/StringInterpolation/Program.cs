using System.Globalization;

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subTotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"      Sub Total: {subTotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"      Total Billed: {total:C}");

// Composite Formatting
Console.WriteLine("");
string first = "Hello";
string second = "World";

string message = string.Format("{0} {1}!", first, second);
Console.WriteLine(message);

// Formatting strings by adding whitespace before or after
Console.WriteLine("");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));  // PadLeft() method 
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));  // PadRight method

Console.WriteLine("");
string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);