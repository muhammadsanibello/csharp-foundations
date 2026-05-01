// Return Value

double minimumSpend = 30.00;
double total = 0;

double[] items = [15.97, 3.50, 12.25, 22.99, 10.98];
double[] discounts = [0.30, 0.00, 0.10, 0.20, 0.50];

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= EligibleDiscount() ? 5.00 : 0;

Console.WriteLine($"Total: ${FormatDecimal(total)}");
double GetDiscountedPrice(int item)
{
    double result = items[item] * (1 - discounts[item]);
    return result;
}

bool EligibleDiscount()
{
    return total >= minimumSpend;
}

string FormatDecimal(double total)
{
    return total.ToString().Substring(0, 5);
}