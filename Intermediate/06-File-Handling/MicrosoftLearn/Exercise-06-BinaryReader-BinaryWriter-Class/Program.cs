// Create a file to write to
using System.Text;

using (FileStream fs = new FileStream("example.dat", FileMode.Create))
{
    using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
    {
        // Write some data
        writer.Write(42); // Integer
        writer.Write(3.14); // Double
        writer.Write("Hello, World!"); // String
    }
}

// Read the data back
using (FileStream fs = new FileStream("example.dat", FileMode.Open))
{
    using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
    {
        int intValue = reader.ReadInt32();
        double doubleValue = reader.ReadDouble();
        string stringValue = reader.ReadString();

        Console.WriteLine($"Integer: {intValue}");
        Console.WriteLine($"Double: {doubleValue}");
        Console.WriteLine($"String: {stringValue}");
    }
}