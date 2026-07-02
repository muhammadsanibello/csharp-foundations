var waitList = new Queue<Subscriber>();

waitList.Enqueue(new Subscriber { FirstName = "Ada" });
waitList.Enqueue(new Subscriber { FirstName = "Grace" });
waitList.Enqueue(new Subscriber { FirstName = "Linus" });

if (waitList.TryDequeue(out var served))
{
    Console.WriteLine(served.FirstName);
}
else
{
    Console.WriteLine("No one left");
}

Console.WriteLine(waitList.Peek().FirstName);

class Subscriber
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public bool HasLikedVideo { get; init; } = true;
}