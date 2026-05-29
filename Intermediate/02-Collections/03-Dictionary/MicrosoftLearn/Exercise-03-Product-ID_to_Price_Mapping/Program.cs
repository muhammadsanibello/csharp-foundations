var productPrices = new Dictionary<int, decimal>
{
    { 201, 19.9m },
    { 202, 29.99m }
};

Console.WriteLine($"Product 201 costs ${productPrices[201]}");