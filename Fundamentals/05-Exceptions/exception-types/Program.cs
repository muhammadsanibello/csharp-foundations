// Catch specific exception types

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occured");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)  // ex object derived from Exception class
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}"); // Using Message property to provide the details about the cause of an error
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    try
    {
        checked
        {
            smallNumber = (byte)number1;
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
}