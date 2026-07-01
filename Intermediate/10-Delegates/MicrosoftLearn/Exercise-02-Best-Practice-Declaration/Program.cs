
namespace MyNamespace
{
    // Define the delegate outside the class
    public delegate void MyDelegate(string message);

    public class Publisher
    {
        // Method that uses the delegate
        public void PublishMessage(MyDelegate del)
        {
            del("Hello from Publisher");
        }
    }

    public class Subsciber
    {
        public void Subscribe()
        {
            // Create an instance of the Publisher class
            Publisher publisher = new Publisher();

            // Create an instance of the delegate and pass a method to it
            MyDelegate del = PrintMessage;
            //del = StoreMessage;

            // Call the method of the publisher class and pass the delegate
            publisher.PublishMessage(del);
        }

        // Method that matches the delegate signature
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void StoreMessage(string message)
        {
            string storage = message;
        }
    }

    class Program
    {
        static void Main()
        {
            Subsciber subsciber = new Subsciber();

            subsciber.Subscribe();
        }
    }
}