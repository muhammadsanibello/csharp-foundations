// ATM Simulator
Console.WriteLine("\t\t\t\t\t\tFIRST BANK OF NIGERIA (est. 1899)\n");
Console.WriteLine("\t\t\t\t\t\tWelcome to First Bank of Nigeria\n");

string userName = "minister";
string? password = "63341234";
string pin = "12345";
decimal balance = 5000000m;
string? response;
bool exit = false;
int maxAttempt = 3;

while (maxAttempt > 0)
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
        maxAttempt--;
    }
        Console.WriteLine();
}

if (maxAttempt == 0)
{
    return;
}

Console.WriteLine("Welcome  Back User!\n");

while (exit == false)
{
    Console.WriteLine("1. Transfer\n2. Withdraw\n3. Check Balance\n4. Airtime/Data\n5. Exit\n");
    response = Console.ReadLine() ?? "";

    try
    {
        if (!(!string.IsNullOrEmpty(response) && response.All(char.IsDigit)))
        {
            throw new ArgumentException("Invalid input! Try again");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Error! " + ex.Message);
    }

    try
    {
        try
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
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error! " + ex.Message);
        }

    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("Error! " + ex.Message);
    }

    Console.WriteLine();
}

void Transfer()
{
    Console.WriteLine("\nEnter recipient\'s account number");
    string accountNumber = Console.ReadLine() ?? "";

    if (!(!string.IsNullOrEmpty(accountNumber) && accountNumber.All(char.IsDigit)))
    {
        throw new ArgumentException("\nInvalid Account Number");
    }

    if (!(accountNumber.Length == 10))
    {
        throw new ArgumentException("Account Number Must be 10 digits");
    }

    decimal amount = GetValidAmount();

    if (ValidatePin())
    {
        balance -= amount;
        Console.WriteLine($"You have successfully sent N{amount} to {accountNumber}. You have N{balance} remain in you account.");
    }
}

void Withdraw()
{
    decimal amount = GetValidAmount();
    if (ValidatePin())
    {
        balance -= amount;
        Console.WriteLine($"You have successfully withdraw N{amount}. Available balance: N{balance}");
    }
}

void BalanceCheck()
{
    if (ValidatePin())
    {
        Console.WriteLine($"\nBalance: N{balance}");
    }
}

void AirtimeData()
{
    Console.WriteLine("\n1. Airtime\n2. Data\n");
    response = Console.ReadLine() ?? "";

    if (!(!string.IsNullOrEmpty(response) && response.All(char.IsDigit)))
    {
        throw new ArgumentException("\nInvalid Input");
    }

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

void Airtime()
{
    Console.WriteLine("\n1. Self\n2. Other\n");
    response = Console.ReadLine() ?? "";

    if (!(!string.IsNullOrEmpty(response) && response.All(char.IsDigit)))
    {
        throw new ArgumentException("Invalid Option!\n");
    }

    if (response == "1")
    {
        decimal amount = GetValidAmount();

        if (ValidatePin())
        {
            balance -= amount;
            Console.WriteLine($"You have successfully purchase airtime of N{amount}. Available balance: N{balance}");
        }
    }

    else if (response == "2")
    {
        string phoneNumber = GetValidNumber();

        decimal amount = GetValidAmount();

        if (ValidatePin())
        {
            balance -= amount;
            Console.WriteLine($"You have successfully purchase N{amount} airtime to {phoneNumber}. Available balance: N{balance}");
        }
    }
    else
    {
        Console.WriteLine("Error! Select \"1\" or \"2\" to purchase.\n");
    }
}

void Data()
{
    Console.WriteLine("\n1. Self\n2. Other\n");
    response = Console.ReadLine() ?? "";

    if (!(!string.IsNullOrEmpty(response) && response.All(char.IsDigit)))
    {
        throw new ArgumentException("Invalid Option!\n");
    }

    if (response == "1")
    {
        decimal amount = GetValidAmount();

        if (ValidatePin())
        {
            balance -= amount;
            Console.WriteLine($"\nYou have successfully purchased Data of N{amount}. Available balance is N{balance}\n");
        }
    }

    else if (response == "2")
    {
        string phoneNumber = GetValidNumber();

        decimal amount = GetValidAmount();

        if (ValidatePin())
        {
            balance -= amount;
            Console.WriteLine($"\nYou have successfully purchased N{amount} Data to {phoneNumber}. Available balance is N{balance}\n");
        }
    }
    else
    {
        Console.WriteLine("Error! Select \"1\" or \"2\" to purchase.\n");
    }
}

// Amount validation
decimal GetValidAmount()
{
    Console.Write("Enter Amount: ");
    string? input = Console.ReadLine();

    if (!decimal.TryParse(input, out decimal amount))
    {
        throw new ArgumentException("Invalid amount");
    }

    if (amount <= 0)
    {
        throw new ArgumentException("Amount must be greater than zero");
    }

    if (amount > balance)
    {
        throw new InvalidOperationException("Insufficient balance");
    }

    return amount;
}

// Pin Validation
bool ValidatePin()
{
    Console.Write("Enter Pin: ");
    string? input = Console.ReadLine();

    if (input == pin)
        return true;

    Console.WriteLine("Invalid Pin!");
    return false;
}

// Phone Number Validation
string GetValidNumber()
{
    Console.Write("Enter recipient\'s phone number: ");
    string? phoneNumber = Console.ReadLine();

    if (!(!string.IsNullOrEmpty(phoneNumber) && phoneNumber.All(char.IsDigit)))
    {
        throw new ArgumentException("Invalid Phone Number");
    }

    if (!(phoneNumber.Length == 11))
    {
        throw new ArgumentException("Phone number must be 11 digits");
    }

    return phoneNumber;
}

void Exit()
{
    exit = true;
}