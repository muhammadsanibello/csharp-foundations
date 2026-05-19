using ATM_System;

// Create Account objects
var account1 = new BankAccount(5000, "1234", "Saving");
var account2 = new BankAccount(3000, "6334", "Current");
var account3 = new BankAccount(2000, "4123", "Saving");

// Depositing 2000 into account 1
Console.WriteLine($"Account 1 before depositing: Balance: {account1.Balance}");
account1.Deposit(2000);
Console.WriteLine($"Account 1 after deposited: Balance: {account1.Balance}\n");

// Withdrawing 1500 from account 2
Console.WriteLine($"Account 2 before withdrawing: Balance: {account2.Balance}");
bool withdrawSuccess = account2.Withdraw(1500, "6334");
Console.WriteLine($"Account 2 after withdrawal: Balance: {account2.Balance}, Withdraw Successful = {withdrawSuccess}\n");

// Transfer 1000 from Account 3 to Account 1
Console.WriteLine($"Account 3 before transfer: Balance: {account3.Balance}");
Console.WriteLine($"Account 1 before transfer: Balance: {account1.Balance}");
bool transferSuccess = account3.Transfer(account1, 1000, "4123");
Console.WriteLine($"Account 3 after transfer: Balance: {account3.Balance}, Transfer Successful = {transferSuccess}");
Console.WriteLine($"Account 1 after transfer: Balance: {account1.Balance}\n");

// Change account2's Pin
Console.WriteLine("Changing account2's Pin...");
account2.ChangePin("6334", "1235");

//Testing account2's new pin
account2.CheckBalance("1235");

Console.WriteLine();

// Display Account 1 Information
Console.WriteLine("Account 1 Information");
Console.WriteLine(account1.DisplayAccountInfo());

Console.WriteLine();

// Changing account1's type
account1.ChangeAccountType("Current", "1234");

Console.WriteLine();

// Demonstrating Changes
Console.WriteLine("Account 1 Information");
Console.WriteLine(account1.DisplayAccountInfo());