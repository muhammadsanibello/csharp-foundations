// Immutable properties using get only, private set.

class Contact
{
    public string Name { get; }
    public string Address { get; private set; }

    public Contact(string contactName, string contactAddress)
    {

        // Both properties are accessible in the constructor
        Name = contactName;
        Address = contactAddress;

    }

    // Name isn't assignable here. This will generate a compile error
    //public void ChangeName(string newName) => Name = newName;

    // Address is assignable here.
    public void ChangeAddress(string newAddress) => Address = newAddress;
}

class Program
{
    static void Main()
    {
        var contact = new Contact("Sani Bello", "Unguwar Yamma");
        Console.WriteLine(contact.Name);
        contact.ChangeAddress("Test");
        Console.WriteLine(contact.Address);
    }
}