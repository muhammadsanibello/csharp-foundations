// Define the parent class 'Artist'
public class Artist
{
    // Initialize the 'Artist' with Name attribute
    private string _name;

    public Artist(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

}

// Define the child class 'Musician', inheriting from 'Artist'
public class Musician : Artist
{
    public string Instrument { get; }

    public Musician(string name, string instrument) : base(name)
    {
        Instrument = instrument;
    }
}

public class Program
{
    static void Main()
    {
        var join = new Musician("John Lennon", "Guitar");
        Console.WriteLine(join.GetName());
        Console.WriteLine(join.Instrument);
    }
}