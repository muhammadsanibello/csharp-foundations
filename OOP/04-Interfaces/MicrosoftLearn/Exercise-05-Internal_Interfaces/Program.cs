internal class InternalConfiguration
{
    public string Setting { get; set; }
}

internal interface ILoggable
{
    void Log(string message);
}

internal interface IConfigurable
{
    void Configure(InternalConfiguration config);
}

public class ServiceImplementation : ILoggable, IConfigurable
{
    // Implicit implementation: ILoggable uses only public types in its signature
    public void Log(string message) => Console.WriteLine($"Log: {message}");

    // Explicit implementation: IConfigurable uses internal types
    void IConfigurable.Configure(InternalConfiguration config)
    {
        Console.WriteLine($"Configured with: {config.Setting}");
    }
}