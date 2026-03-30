// Pallets identifier
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
// Sorted the elements of Array
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--- {pallet}");
}

Console.WriteLine("");
// Reversed the order of elements of an Array
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--- {pallet}");
}