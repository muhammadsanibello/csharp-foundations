public delegate void Notify(string message);

public class Program
{
    public static void Main()
    {
        // Create an instance of the delegate using a method group conversion
        Notify notifyMethodGroup = NotificationService.SendNotification;

        // Create an instance of the delegate using an anonymous method
        Notify notifyAnonymous = delegate (string message) { Console.WriteLine($"Anonymous notification: {message}"); };

        // Create an instance of the delegate using a lambda expressions
        Notify notifyLambda = (message) => Console.WriteLine($"Lambda notification: {message}");

        // Invoke the delegate
        notifyMethodGroup.Invoke("Hello, World");

        // Invoke the delegate
        notifyAnonymous("Hello from Anonymous Method!");

        // Invoke the delegate
        notifyLambda("Hello from Lambda!");
    }
}

public static class NotificationService
{
    // Method that matches the delegate's signature
    public static void SendNotification(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }
}