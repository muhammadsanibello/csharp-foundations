string[] fraudulentOrderID = new string[3];

fraudulentOrderID[0] = "A123";
fraudulentOrderID[1] = "B456";
fraudulentOrderID[2] = "C789";
//fraudulentOrderID[3] = "21";

Console.WriteLine($"First: {fraudulentOrderID[0]}");
Console.WriteLine($"Second: {fraudulentOrderID[1]}");
Console.WriteLine($"Third: {fraudulentOrderID[2]}");

// Overide the first element
fraudulentOrderID[0] = "F200";
Console.WriteLine($"Reassign first: {fraudulentOrderID[0]}");

// another order
string[] fraudulentOrderID1 = ["A123", "B456", "C789"];

Console.WriteLine(fraudulentOrderID1[0]);
Console.WriteLine(fraudulentOrderID1.Length);

// foreach statement
foreach (string fraud in fraudulentOrderID1)
{
    Console.WriteLine(fraud);
}