// SIM checker program

string[] phoneNumbers = ["07045435653", "08137097889", "07030778463", "08061664059", "08033808619", "08063636110", "07033637425", "08076544325", "09165544573", "08043345623"];

string? enteredNumber = "";
int countSuccessful = 0;
int countFailed = 0;

while (true)
{
    Console.WriteLine("Enter a phone number:");
    enteredNumber = Console.ReadLine();

    if (enteredNumber == "exit")
    {
        break;
    }

    if ((!string.IsNullOrEmpty(enteredNumber)) && (enteredNumber.Length == 11) && (enteredNumber.All(char.IsDigit)))
    {
        if (phoneNumbers.Contains(enteredNumber))
        {
            Console.WriteLine("Number is registerd.\n");
            countSuccessful++;
        }

        else
        {
            Console.WriteLine("Number not found.\n");
            countFailed++;
        }
    }

    else
    {
        Console.WriteLine($"InvalidNumber! Must be 11 digits.\n");
    }

} // (enteredNumber != "exit");

Console.WriteLine($"Total successful searches: {countSuccessful}");
Console.WriteLine($"Total failed searches: {countFailed}");