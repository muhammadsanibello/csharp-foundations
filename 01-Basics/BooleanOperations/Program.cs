string name = "Sani is a Boy";
Console.WriteLine(name.Contains("is"));
Console.WriteLine(!name.Contains("Young"));

int salesAmount = 10001;
Console.WriteLine($"Discount: {(salesAmount > 1000 ? 100 : 50)}");
int discount = salesAmount > 1000 ? 100 : 50;
Console.WriteLine(discount);