// Write data to a file
string path = "example.txt";
byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
{
    fs.Write(data, 0, data.Length);
}

Console.WriteLine("Data written to file");

// Read data from a file
byte[] buffer = new byte[1024]; // Adjust buffer size as needed

using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    int bytesRead = fs.Read(buffer, 0, buffer.Length);
    string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
    Console.WriteLine("Data read from file: " + readData);
}

// Read, Write and seek within a file
string path1 = "example1.txt";
byte[] data1 = System.Text.Encoding.UTF8.GetBytes("Hello, Muhammad!");

// Writing to the file
using (FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write))
{
    fs.Write(data1, 0, data1.Length);
}

// Reading from the file

using (FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read))
{
    byte[] buffer1 = new byte[data1.Length];
    fs.Seek(0, SeekOrigin.Begin);
    int bytesRead = fs.Read(buffer1, 0, buffer1.Length);
    string readData = System.Text.Encoding.UTF8.GetString(buffer1, 0, bytesRead);
    Console.WriteLine(readData);
}

// Implement access control 
string path2 = "example2.txt";
byte[] data2 = System.Text.Encoding.UTF8.GetBytes("Hello, Buskuri");

// Write to the file
using (FileStream fs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 409, false))
{
    fs.Write(data2, 0, data2.Length);
    fs.Flush();
}

// Read from the file
using (FileStream fs = new FileStream(path2, FileMode.Open, FileAccess.Read, FileShare.None, 4096, false))
{
    byte[] buffer2 = new byte[data2.Length];
    int bytesRead = fs.Read(buffer2, 0, buffer2.Length);
    string readData = System.Text.Encoding.UTF8.GetString(buffer2, 0, bytesRead);
    Console.WriteLine(readData);
}