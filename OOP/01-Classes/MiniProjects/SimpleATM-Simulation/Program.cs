// Simple ATM Simulation

using SimpleATM_Simulation;

var account1 = new ATMAccount("Sani Bello", "1234", 5000);
var account2 = new ATMAccount("Saad Bello", "6334", 6000);
var account3 = new ATMAccount("Sale Bello", "4321", 7000);

account1.DisplayAccountName();
account1.CheckBalance("1234");
account1.Withdraw("1233", 3000);
account1.Deposit(2000);
account1.CheckBalance("1234");

Console.WriteLine();

account2.DisplayAccountName();
account2.CheckBalance("6334");