// C# Class definition

namespace Devices
{
    public class Phone
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }

        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine($"Texting {phoneNumber}: {message}");
        }
    }
}
