// IComparable<T> interface allows objects to be compare by type:
public class Product : IComparable<Product>
{
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other?.Price);
    }
}

// Example of using ICompare<T> to sort a list of products:
public class ProductCompare : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        return x.Price.CompareTo(y.Price);
    }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Tablet", Price = 600 },
            new Product { Name = "Desktop", Price = 300 }
        };

        products.Sort(new ProductCompare());

        Console.WriteLine(products[0].Name);
    }
}