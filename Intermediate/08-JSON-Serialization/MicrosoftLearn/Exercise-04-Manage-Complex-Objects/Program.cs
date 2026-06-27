// Circular Reference
using System.Text.Json;
using System.Text.Json.Serialization;

class Person
{
    public string? Name { get; set; }
    public List<Pet> Pets { get; set; }

}

class Pet
{
    public string? Name { get; set; }
    public Person? Owner { get; set; }
}

class Program
{
    static void Main()
    {
        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };

        var person = new Person
        {
            Name = "John",
            Pets = new List<Pet>
            {
                new Pet { Name = "Fido", Owner = null },
                new Pet { Name = "Whiskers", Owner = null }
            }
        };

        person.Pets[0].Owner = person;
        person.Pets[1].Owner = person;

        var json = JsonSerializer.Serialize(person, options);
        Console.WriteLine(json);

        var deserializedPerson = JsonSerializer.Deserialize<Person>(json, options);

        foreach (var pet in deserializedPerson.Pets)
        {
            Console.WriteLine($"Pet Name: {pet.Name}, Pet Owner: {pet.Owner.Name}");
        }

    }
}