using BankAccountSystem;

var account1 = new BankAccount();
var account2 = new BankAccount("Sani");
var account3 = new BankAccount("Bello", 5000);

account1.DisplayInfo();
account1.Deposit(0);
account1.Withdraw(1000);
account1.CheckBalance();

Console.WriteLine();

account2.DisplayInfo();
account2.Deposit(2000);
account2.Withdraw(1500);
account2.CheckBalance();

Console.WriteLine();

account3.DisplayInfo();
account3.Withdraw(6000);
account3.CheckBalance();
