// Creating a File
string path = "sample.txt";
File.WriteAllText(path, "Hello, File Handling in C#!");
File.AppendAllText(path, "\nHello Again\n");
Console.WriteLine("File created successfully.");

// Writing to a file
using (StreamWriter writer = new StreamWriter(path, true))
{
    writer.WriteLine("Line 1");
    writer.WriteLine("Line 2");
}

Console.WriteLine("Data written to file.");

// Reading from a file
using (StreamReader reader = new StreamReader(path))
{
    Console.WriteLine("File Content");
    
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Working with  Binary Files
using (BinaryWriter writer = new BinaryWriter(File.Open("numbers.bin", FileMode.Create)))
{
    writer.Write(100);

    writer.Write(200);
}

//File.Delete(path);

using (BinaryReader reader = new BinaryReader(File.Open("numbers.bin", FileMode.Open)))
{
    Console.WriteLine(reader.ReadInt32());

    Console.WriteLine(reader.ReadInt32());
}

// File Information
FileInfo info = new FileInfo("numbers.bin");
Console.WriteLine($"File Name: {info.Name}");
Console.WriteLine($"Size: {info.Length} bytes");
Console.WriteLine($"Creaed: {info.CreationTime}");

// Copy and move files
try
{
    File.Copy(path, "number.txt");
    File.Move(path, "numbe.txt");
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}