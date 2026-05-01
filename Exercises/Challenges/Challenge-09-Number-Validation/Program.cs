string? input;

Console.WriteLine("Enter integer number between 5 and 10");

bool validInteger = false;
int convertedInput = 0;

do
{
    input = Console.ReadLine();
    bool converter = int.TryParse(input, out convertedInput);

    if ((convertedInput <= 5) && (convertedInput >= 10))
    {
        if ((convertedInput >= 5) && (convertedInput <= 10))
            validInteger = true;

        else
            Console.WriteLine($"You entered {input}, please enter a number between 5 and 10.");
    }

    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (validInteger == false);

Console.WriteLine($"Your value {(input)} has been successfully accepted");