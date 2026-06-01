var product1 = new Product("Laptop", 2000m);
var product2 = new Product("Laptop", 2000m);
var produt3 = new Product("Tablet", 1000m);

Console.WriteLine($"Are product1 and product2 equal? {product1 == product2}");
Console.WriteLine($"Are product1 and product3 equal? {product1 == produt3}");

public record Product(string Name, decimal Price);