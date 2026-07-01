public class TestClass
{
    static void Main()
    {
        Action<string> printMessage = (message) => Console.WriteLine(message);
        printMessage("Hello, World");

        Action<string> reversePrint = (input) =>
        {
            char[] charArray = input.ToCharArray();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
        };
        reversePrint("Buskuri");

        // Action delegate with no parameter
        Action sayHello = () => Console.WriteLine("Hello, World!");
        sayHello();

        // Action delegate with two parameters
        Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
        printSum(5, 5);
    }
}