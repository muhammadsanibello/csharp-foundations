// Wallet / Expense Tracker

using Wallet_Expense_Tracker;

var wallet = new Wallet();

// Summary Report
Console.WriteLine("Summary report:");
Console.WriteLine(wallet.Summary());

Console.WriteLine();

// Add Money
wallet.AddMoney(5000);

// Check Balance
wallet.CheckBalance();

// Remove money
wallet.RemoveMoney(3000);

// Check Balance
wallet.CheckBalance();

wallet.AddMoney(6000);
wallet.RemoveMoney(400);

Console.WriteLine();

// Summary Report
Console.WriteLine("Summary Report");
Console.WriteLine(wallet.Summary());