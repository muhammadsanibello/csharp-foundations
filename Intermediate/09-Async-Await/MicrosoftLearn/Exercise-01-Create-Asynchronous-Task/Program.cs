using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        string filePath = "example.txt";
        string content = await ReadFileAsync(filePath);
        Console.WriteLine(content);
    }

    public static async Task<string> ReadFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            return content;
        }
    }
}