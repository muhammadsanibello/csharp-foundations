public class Box<T>
{
    public T? Item { get; set; }

    public void AddItem(T item)
    {
        Item = item;
    }
}

class Program
{
    static void Main()
    {
        var box1 = new Box<int>();
        var box2 = new Box<string>();

        box1.AddItem(20);
        Console.WriteLine(box1.Item);
    }
}