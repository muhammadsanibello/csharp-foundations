using Banking_Management_System_V2;

try
{
    // Create bank account numbers
    BankAccountNumber accountNumber1 = new BankAccountNumber("7045435653");
    BankAccountNumber accountNumber2 = new BankAccountNumber("7045435654");
    BankAccountNumber accountNumber3 = new BankAccountNumber("7045435655");

    // Creating Savings Account object
    BankAccount savings = new SavingsAccount(accountNumber1, "Sani Bello", 1000m);

    savings.Deposit(200m);
    savings.Withdraw(1100m);
    savings.ShowTransactionHistory();
    savings.DisplayInfo();

    // Creating Current Account object
    BankAccount current = new CurrentAccount(accountNumber2, "Usman Musa", 1500m);

    // Demonstrating methods
    current.Deposit(1500m);
    current.Withdraw(800m);
    current.ShowTransactionHistory();
    current.DisplayInfo();

    // Creating Fixed Deposit Account object
    BankAccount fixedDeposit = new FixedDepositAccount(accountNumber3, "Umar Ahmad", 2000m);

    // Demonstrating methods
    fixedDeposit.Deposit(400m);
    fixedDeposit.ShowTransactionHistory();
    fixedDeposit.DisplayInfo();

    // Creating Bank object
    var bank = new Bank("First Bank", "Jama`are Road");

    // Demonstrating methods
    bank.AddAccount(savings);
    bank.AddAccount(current);

    bank.DisplayAllAccounts();

    // Demonstrate transfer method
    bool transferSuccess = current.Transfer(savings, 10);

    if (transferSuccess)
    {
        Console.WriteLine("Transfer success");
    }
    else
    {
        Console.WriteLine("Transfer failed");
    }
    savings.DisplayInfo();
    current.DisplayInfo();
    current.ShowTransactionHistory();

    bool removeSuccess = bank.RemoveAccount(accountNumber1);

    if (!removeSuccess)
    {
        Console.WriteLine("Account doesn't exist in the bank");
    }

    BankAccount account = bank.SearchAccount(accountNumber2);

    if (account == null)
    {
        Console.WriteLine("Account not found");
    }
    else
    {
        account.DisplayInfo();
    }

    // Try withdrawal method in fixed deposit account
    fixedDeposit.Withdraw(300m);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}