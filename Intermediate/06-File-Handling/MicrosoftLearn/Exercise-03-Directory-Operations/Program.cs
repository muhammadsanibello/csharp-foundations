// Create Directory
Directory.CreateDirectory("MyFolder");
Directory.Delete("MyFolder");
Console.WriteLine("Directory created.");

string[] files = Directory.GetFiles(".");
Console.WriteLine("Files in current directory");

foreach (string file in files)
{
    Console.WriteLine(file);
}