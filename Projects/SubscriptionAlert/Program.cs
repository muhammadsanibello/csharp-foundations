Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your Subscription has expired");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription will expire within a day");
    discountPercentage += 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    discountPercentage += 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("You subscription will expire soon.");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and enjoy {discountPercentage}% discount.");
}