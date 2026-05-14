using Banking_Management_System_V2;

try
{

    // Creating Savings Account object
    BankAccount savings1 = new SavingsAccount("Sani Bello", 1000);

    savings1.Withdraw(900);
    savings1.Deposit(-9);
    savings1.ShowTransactionHistory();
    savings1.DisplayInfo();

    // Creating Current Account object
    BankAccount current1 = new CurrentAccount("Usman Musa", 1500);

    // Demonstrating methods
    current1.Deposit(0);
    current1.Withdraw(6500);
    current1.Withdraw(100);
    current1.ShowTransactionHistory();
    current1.DisplayInfo();

    // Creating Fixed  Deposit Account object
    BankAccount fixed1 = new FixedDepositAccount("Umar Ahmad", 2000);

    // Demonstrating methods
    fixed1.Deposit(10);
    fixed1.Withdraw(2);
    fixed1.ShowTransactionHistory();
    fixed1.DisplayInfo();

    // Creating Bank object
    var bank = new Bank("First Bank", "Jama`are Road", 1000);

    // Demonstrating methods
    bank.AddAccount(savings1);
    bank.AddAccount(current1);

    bank.RemoveAccount("0014580341");


    bool searchSuccess = bank.SearchAccount("0014580341");

    if (searchSuccess)
    {
        Console.WriteLine("Found!");
    }
    else
    {
        Console.WriteLine("Not Found");
    }

        bank.DisplayAllAccounts();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}