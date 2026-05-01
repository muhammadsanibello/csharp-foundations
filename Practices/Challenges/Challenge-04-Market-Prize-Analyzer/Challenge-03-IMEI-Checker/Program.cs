// IMEI Blaclist Checker Program

string[] blacklistedIMEIs = ["202303303339395", "567487328907658", "342678905423456", "342567890123456", "234567654321908"];

string? inputedIMEI;

while (true)
{
    Console.WriteLine("Enter an IMEI Number:\n");
    inputedIMEI = Console.ReadLine();

    if (inputedIMEI == "exit")
    {
        break;
    }

    if ((!string.IsNullOrEmpty(inputedIMEI) && (inputedIMEI.Length == 15)))
    {
        if (blacklistedIMEIs.Contains(inputedIMEI))
        {
            Console.WriteLine("This phone is reported stolen!\n");
        }

        else
        {
            Console.WriteLine("Phone is Clean.\n");
        }
    }

    else
    {
        Console.WriteLine("Characters must be 15 in lenght.\n");
    }
}