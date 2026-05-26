using System;

namespace LoggingApplication
{
    public class ConsoleLogger : ILogger
    {
        // Logs a message to the console.
        public void Log(string message)
        {
            Console.WriteLine($"ConsoleLogger: {message}");
        }
    }
}
