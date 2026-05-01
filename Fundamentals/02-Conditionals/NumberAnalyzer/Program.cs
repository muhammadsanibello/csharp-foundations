// Number Analyzer

bool option = false;
do
{
    Console.Write("Enter a Number: ");
    string? response = Console.ReadLine();

    if (int.TryParse(response, out int number))
    {
        if (number > 0)
        {
            if (number % 2 == 0)
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("\nNumber is Positive, Even, and Divisible by 5!");
                }
                else
                {
                    Console.WriteLine("\nNumber is Positive and Even!");
                }
            }
            else
            {
                Console.WriteLine("\nNumber is Positive and Odd!");
            }
        }
        else if (number < 0)
        {
            Console.WriteLine("\nNumber is Negative!");
        }
        else
        {
            Console.WriteLine("\nNumber is Zero!");
        }
    }
    else
    {
        Console.WriteLine("\nInvalid Number! Try again.");
    }

    Console.WriteLine("\nDo you like to continue? 'Yes\\No'");
    response = Console.ReadLine();

    if (response.ToLower().Trim() == "yes")
    {
        option = true;
    }
    else if (response.ToLower().Trim() == "no")
    {
        option = false;
    }
    else
    {
        Console.WriteLine("\nInvalid Option. \"Option is either 'Yes' or 'No'\"");
        break;
    }
} while (option == true);