// ATM Simulator
Console.WriteLine("\t\t\t\t\t\tFIRST BANK OF NIGERIA (est. 1899)\n");
Console.WriteLine("\t\t\t\t\t\tWelcome to First Bank of Nigeria\n");

string userName = "minister";
string? password = "63341234";
string pin = "12345";
decimal balance = 5000000m;
string? response;
bool exit = false;

while (true)
{
    Console.Write("\t\t\t\t\t\tUserName: ");
    string? username  = Console.ReadLine();

    Console.Write("\t\t\t\t\t\tPassword: ");
    string? passwordResponse = Console.ReadLine();

    if (username == userName && passwordResponse == password)
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("\n\t\t\t\t\t\tInvalid Credential! Try again.");
    }
        Console.WriteLine();
}

Console.WriteLine("Welcome  Back User!\n");

while (exit == false)
{
    Console.WriteLine("1. Transfer\n2. Withdraw\n3. Check Balance\n4. Airtime/Data\n5. Exit\n");
    response = Console.ReadLine() ?? "";

    if (response.All(char.IsDigit) && !string.IsNullOrEmpty(response))
    {
        switch (response)
        {
            case "1":
                Transfer();
                break;
            case "2":
                Withdraw();
                break;
            case "3":
                BalanceCheck();
                break;
            case "4":
                AirtimeData();
                break;
            case "5":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid Option!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Try again");
    }
    Console.WriteLine();
}

void Transfer()
{
    Console.WriteLine("\nEnter recipient\'s account number");
    string accountNumber = Console.ReadLine() ?? "";

    if (accountNumber.All(char.IsDigit) && !string.IsNullOrEmpty(accountNumber))
    {
        if (accountNumber.Length == 10)
        {
            Console.Write("\nEnter Amount: ");
            response = Console.ReadLine();

            if (decimal.TryParse(response, out decimal amount))
            {
                if (amount <= balance)
                {
                    Console.Write("\nEnter Pin: ");
                    response = Console.ReadLine();

                    if (response == pin)
                    {
                        balance -= amount;
                        Console.WriteLine($"\nYou have successfully sent N{amount} to {accountNumber}. Your Available balance is N{balance}");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Pin! Try again");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Insuffient balance! Your current balance is N{balance}");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Amount!");
            }
        }
        else
        {
            Console.WriteLine("\nError! Account number must be 10 digits.");
        }
    }
    else
    {
        Console.WriteLine("\nInvalid Account Number!");
    }
}

void Withdraw()
{
    Console.WriteLine("\nEnter Account Number:");
    response = Console.ReadLine() ?? "";

    if (!string.IsNullOrEmpty(response) && response.All(char.IsDigit))
    {
        if (response.Length == 10)
        {
            Console.Write("\nEnter Amount: ");
            response = Console.ReadLine();

            if (decimal.TryParse(response, out decimal amount))
            {
                if (amount <= balance)
                {
                    Console.Write("\nEnter Pin: ");
                    response = Console.ReadLine();

                    if (response == pin)
                    {
                        balance -= amount;
                        Console.WriteLine($"\nYou have successfully withdraw N{amount} to {response}. You available balance is N{balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin! Try again");
                    }
                }
                else
                {
                    Console.WriteLine("\nInsufficient balance!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Amount!");
            }
        }
        else
        {
            Console.WriteLine("\nError! Account Number Must be 10 digits");
        }
    }
    else
    {
        Console.WriteLine("\nInvalid Account Number");
    }
}

void BalanceCheck()
{
    Console.Write("\nEnter Pin: ");
    response = Console.ReadLine();

    if (response == pin)
    {
        Console.WriteLine($"\nBalance: N{balance}");
    }
    else
    {
        Console.WriteLine("\nInvalid Pin! Try Again");
    }
}

void AirtimeData()
{
    Console.WriteLine("\n1. Airtime\n2. Data\n");
    response = Console.ReadLine() ?? "";

    if (response.All(char.IsDigit) && !string.IsNullOrEmpty(response))
    {
        if (response == "1")
        {
            Airtime();
        }

        else if (response == "2")
        {
            Data();
        }
        else
        {
            Console.WriteLine("\nInvalid Option!");
        }
    }
    else
    {
        Console.WriteLine("\nInvalid Input!");
    }

}

void Airtime()
{
    Console.WriteLine("\n1. Self\n2. Other\n");
    response = Console.ReadLine() ?? "";

    if (response.All(char.IsDigit) && !string.IsNullOrEmpty(response))
    {
        if (response == "1")
        {
            Console.Write("\nEnter Amount: ");
            response = Console.ReadLine();

            if (decimal.TryParse(response, out decimal amount))
            {
                if (amount <= balance)
                {
                    Console.Write("\nEnter Pin: ");
                    response = Console.ReadLine();

                    if (response == pin)
                    {
                        balance -= amount;
                        Console.WriteLine($"\nYou have successfully purchased Airtime of N{amount}! Available balance is N{balance}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Pin! Try again");
                    }
                }
                else
                {
                    Console.WriteLine("\nInsufficient Balance!\n");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Amount!\n");
            }
        }

        else if (response == "2")
        {
            Console.WriteLine("\nEnter recipient\'s phone number\n");
            string? phoneNumber = Console.ReadLine() ?? "";

            if (phoneNumber.All(char.IsDigit) && !string.IsNullOrEmpty(phoneNumber))
            {
                if (phoneNumber.Length == 11)
                {
                    Console.Write("\nEnter Amount: ");
                    response = Console.ReadLine();

                    if (decimal.TryParse(response, out decimal amount))
                    {
                        if (amount <= balance)
                        {
                            Console.Write("\nEnter Pin: ");
                            response = Console.ReadLine();

                            if (response == pin)
                            {
                                balance -= amount;
                                Console.WriteLine($"\nYou have successfully purchased N{amount} airtime to {phoneNumber}. Available balance is N{balance}\n");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Pin! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insuffient Balance!\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Amount\n");
                    }
                }
                else
                {
                    Console.WriteLine("Phone Number must be 11 digits.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid Phione Number!\n");
            }
        }
        else
        {
            Console.WriteLine("Error! Select \"1\" or \"2\" to purchase.\n");
        }
    }
    else
    {
        Console.WriteLine("Invalid Option!\n");
    }
}

void Data()
{
    Console.WriteLine("\n1. Self\n2. Other\n");
    response = Console.ReadLine() ?? "";

    if (response.All(char.IsDigit) && !string.IsNullOrEmpty(response))
    {
        if (response == "1")
        {
            Console.Write("\nEnter Amount: ");
            response = Console.ReadLine();

            if (decimal.TryParse(response, out decimal amount))
            {
                if (amount <= balance)
                {
                    Console.Write("\nEnter Pin: ");
                    response = Console.ReadLine();

                    if (response == pin)
                    {
                        balance -= amount;
                        Console.WriteLine($"\nYou have successfully purchased Data of N{amount}. Available balance is N{balance}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Pin! Try again");
                    }
                }
                else
                {
                    Console.WriteLine("\nInsufficient Balance!\n");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Amount!\n");
            }
        }

        else if (response == "2")
        {
            Console.WriteLine("\nEnter recipient\'s phone number\n");
            string? phoneNumber = Console.ReadLine() ?? "";

            if (phoneNumber.All(char.IsDigit) && !string.IsNullOrEmpty(phoneNumber))
            {
                if (phoneNumber.Length == 11)
                {
                    Console.Write("\nEnter Amount: ");
                    response = Console.ReadLine();

                    if (decimal.TryParse(response, out decimal amount))
                    {
                        if (amount <= balance)
                        {
                            Console.Write("\nEnter Pin: ");
                            response = Console.ReadLine();

                            if (response == pin)
                            {
                                balance -= amount;
                                Console.WriteLine($"\nYou have successfully purchased N{amount} Data to {phoneNumber}. Available balance is N{balance}\n");
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Pin! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insuffient Balance!\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Amount\n");
                    }
                }
                else
                {
                    Console.WriteLine("Phone Number must be 11 digits.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid Phone Number!\n");
            }
        }
        else
        {
            Console.WriteLine("Error! Select \"1\" or \"2\" to purchase.\n");
        }
    }
    else
    {
        Console.WriteLine("Invalid Option!\n");
    }
}

void Exit()
{
    exit = true;
}