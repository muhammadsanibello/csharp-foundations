public class Person : IComparable<Person>
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        if (other == null) return 1; // If 'other' is null, this instance is considered greater.
        return this.Age.CompareTo(other.Age); // Returns negative value if precedes 'other', 0 if same position, or positive value if follows 'other'.
    }
}