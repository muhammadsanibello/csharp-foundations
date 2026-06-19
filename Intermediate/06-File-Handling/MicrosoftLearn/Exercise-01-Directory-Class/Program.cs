// Read through and list the names of the 'csharp-foundation' root folder top-level directories
var listOfDirectories = Directory.EnumerateDirectories(@"C:\Users\FUJITSU\Desktop\csharp-foundations");

foreach (var directory in listOfDirectories)
{
    Console.WriteLine(directory);
}

// List files in a specific directory
var files = Directory.EnumerateFiles($@"C:{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}FUJITSU{Path.DirectorySeparatorChar}Desktop{Path.DirectorySeparatorChar}csharp-foundations");

foreach (var file in files)
{
    Console.WriteLine(file);
}

// Find all *.md files in the csharp-foundations folder and its subfolders
var allFilesInAllFolders = Directory.EnumerateFiles(@"C:\Users\FUJITSU\Desktop\csharp-foundations", "*.md", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}

// Return the current diretory
Console.WriteLine(Directory.GetCurrentDirectory());

// Retrieve path to special system folder
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docPath);

// Special path character
Console.WriteLine(Path.DirectorySeparatorChar);

// Determine the file info
foreach (var file in files)
{
    FileInfo info = new FileInfo(file);
    Console.WriteLine(info.FullName);
    Console.WriteLine(info.Directory);
    Console.WriteLine(info.CreationTime);
    Console.WriteLine(Path.GetExtension(file));
}

// Create directories
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), docPath, "Hello, World"));

// Checking the existence of a directory
bool exist = Directory.Exists(docPath);
Console.WriteLine(exist);

// Create Files
File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), docPath, "greeting.tx"), "Hello, World");

// Read data from file
string str = File.ReadAllText(@"C:\Users\FUJITSU\Documents\greeting.tx");
Console.WriteLine(str);