// Define an enum for the days of the week
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursady,
    Friday,
    Saturday
}

// Setting underlying types and values for enums
enum ErrorCode : ushort
{
    None = 0,
    Unknown = 1,
    ConnectionLost = 100,
    OutlierReading = 200
}

class Program
{
    static void Main()
    {
        // Perform conversions with enums
        DaysOfWeek day = (DaysOfWeek)3;
        Console.WriteLine(day);

        // validating enum values
        bool isValid = Enum.IsDefined(typeof(DaysOfWeek), 3);
        Console.WriteLine(isValid);
    }
}