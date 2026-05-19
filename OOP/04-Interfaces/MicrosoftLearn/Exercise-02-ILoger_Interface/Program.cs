// Declare an interface

interface ILogger
{
    void Log(string message);
    string Name { get; }
}

// Implement an interface
public class ConsoleLogger : ILogger
{
    public string Name => "Console";

    public void Log(string message) => Console.WriteLine($"[{Name}] {message}");
}

public class FileLogger : ILogger
{
    public string Name => "File";

    public void Log(string message)
    {
        // In a real app, write to a file
        Console.WriteLine($"[{Name}] Writing to file: {message}");
    }
}

public class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        ILogger logger2 = new FileLogger();
        logger.Log("I am a coder");
        logger2.Log("I am a programmer");
        Console.WriteLine(logger.Name);
        Console.WriteLine(logger2.Name);
    }
}