using Banking_Management_System_V2;

try
{

    // Creating Savings Account object
    BankAccount savings1 = new SavingsAccount("Sani Bello", 1000);

    savings1.Withdraw(900);
    savings1.Deposit(900);
    savings1.ShowTransactionHistory();
    savings1.DisplayInfo();

    // Creating Current Account object
    BankAccount current1 = new CurrentAccount("Usman Musa", 1500);

    // Demonstrating methods
    current1.Deposit(500);
    current1.Withdraw(7000);
    current1.ShowTransactionHistory();
    current1.DisplayInfo();

    // Creating Fixed Deposit Account object
    BankAccount fixed1 = new FixedDepositAccount("Umar Ahmad", 2000);

    // Demonstrating methods
    fixed1.Deposit(10);
    fixed1.Withdraw(200);
    fixed1.ShowTransactionHistory();
    fixed1.DisplayInfo();

    // Creating Bank object
    var bank = new Bank("First Bank", "Jama`are Road");

    // Demonstrating methods
    bank.AddAccount(savings1);
    bank.AddAccount(current1);

    bank.DisplayAllAccounts();

    bool removeSuccess = bank.RemoveAccount("0014580341");

    if (!removeSuccess)
    {
        Console.WriteLine("Account doesn't exist in the bank");
    }

    BankAccount account = bank.SearchAccount("0014580341");

    if (account == null)
    {
        Console.WriteLine("Account not found");
    }
    else
    {
        account.DisplayInfo();
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}