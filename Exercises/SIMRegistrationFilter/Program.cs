string[] phoneNumbers = ["07045435653", "08137097889", "07030778463", "08061664059", "08033808619", "08063636110", "07033637425", "08076544325", "09165544573", "08043345623"];

string validInput = "";
string? enteredNumber = "";
int countSuccessful = 0;
int countFailed = 0;

while (true)
{
    if (enteredNumber == "exit")
        break;

    Console.WriteLine("Enter a phone number:");
    enteredNumber = Console.ReadLine();

    bool foundMatch = false;

    if ((!string.IsNullOrEmpty(enteredNumber)) && (enteredNumber.Length == 11) && (enteredNumber.All(char.IsDigit)))
    {
        foreach (var phoneNumber in phoneNumbers)
        {
            if (phoneNumber == validInput)
            {
                foundMatch = true;
                countSuccessful++;
                break;
            }
        }

        if (foundMatch)
        {
            Console.WriteLine("Number is registered.\n");
        }

        else
        {
            countFailed++;
            Console.WriteLine("Number not found.\n");
        }
    }

    else if (enteredNumber == "exit")
    {
        Console.WriteLine("Exitting....\n");
    }

    else
    {
        Console.WriteLine($"InvalidNumber! Must be 11 digits.\n");
    }
}

Console.WriteLine($"Total successful searches: {countSuccessful}");
Console.WriteLine($"Total failed searches: {countFailed}");