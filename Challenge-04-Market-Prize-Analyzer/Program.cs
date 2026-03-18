// Market Price Analyzer Program

int[] prices = [45000, 60000, 30000, 25000, 80000, 15000, 50000, 100000];

if (prices.Length == 0)
{
    Console.WriteLine("There is no data in the prices array");
    return;
}

int cheapest = prices[0];
int expensive = prices[0];
double averagePrice = 0;
int above50000 = 0;

foreach (int price in prices)
{
    averagePrice += price;

    if (price < cheapest)
    {
        cheapest = price;
    }

    if (price > expensive)
    {
        expensive = price;
    }

    if (price > 50000)
    {
        above50000++;
    }
}

averagePrice /= prices.Length;

Console.WriteLine($"The cheapest phone cost: {cheapest}.");
Console.WriteLine($"The most expensive phone cost: {expensive}.");
Console.WriteLine($"The Average prices of phones is {averagePrice}.");
Console.WriteLine($"There are total of {above50000} phones that cost above 50,000.");