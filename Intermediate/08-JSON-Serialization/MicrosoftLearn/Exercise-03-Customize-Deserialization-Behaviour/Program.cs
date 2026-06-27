using System.Text.Json;
using System.Text.Json.Serialization;

// Type-level preference is Populate
[JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
class A
{
    // For this property only, use Replace behavior.
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Replace)]
    public List<int> Numbers1 { get; } = [1, 2, 3];
    public List<int> Numbers2 { get; set; } = [1, 2, 3];
}

class Program
{
    static void Main()
    {
        var json = """{"Numbers1": [4, 5, 6], "Numbers2": [4, 5, 6]}""";
        var a = JsonSerializer.Deserialize<A>(json);

        Console.WriteLine(string.Join(", ", a.Numbers1));
        Console.WriteLine(string.Join(", ", a.Numbers2));
    }
}