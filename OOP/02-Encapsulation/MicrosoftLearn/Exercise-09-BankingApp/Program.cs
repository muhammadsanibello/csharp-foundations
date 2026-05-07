// Banking App project

using Exercise_09_BankingApp;

// Step 1: Create BankCustomer object
Console.WriteLine("Creating BankCustomer objects...");
string firstName = "Sani";
string lastName = "Bello";

BankCustomer customer1 = new BankCustomer(firstName, lastName);

firstName = "Lisa";
BankCustomer customer2 = new BankCustomer(firstName, lastName);

firstName = "Sandy";
lastName = "Goza";
BankCustomer customer3 = new BankCustomer(firstName, lastName);

Console.WriteLine($"BankCustomer 1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");
Console.WriteLine($"BankCustomer 2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerId}");
Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");

// Step 2: Create BankAccount objects for customers
Console.WriteLine("Creating BankAccount objects for customers...");
BankAccount account1 = new BankAccount(customer1.CustomerId);
BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

Console.WriteLine($"Account 1: Account # {account1.AccountNumber}, type {account1.AccountType}, balance {account1.Balance}, rate {BankAccount.InterestRate}, customer ID {account1.CustomerId}");
Console.WriteLine($"Account 2: Account # {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance}, rate {BankAccount.InterestRate}, customer ID {account2.CustomerId}");
Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");


// Demonstrate the use of BankAccount methods
Console.WriteLine("\nDemonstrating BankAccount methods...");

// Deposit
Console.WriteLine("Depositing 500 into Account 1...");
account1.Deposit(500);
Console.WriteLine($"Account 1 after deposit: Balance = {account1.Balance}");

// Withdraw
Console.WriteLine("Withdrawing 200 from Account 2...");
bool withdrawSuccess = account2.Withdraw(200);
Console.WriteLine($"Account 2 after withdrawal: Balance = {account2.Balance}, withdrawal successful: {withdrawSuccess}");

// Transfer
Console.WriteLine("Transferring 300 from Account 3 to Account 1...");
bool transferSuccess = account3.Transer(account1, 300);
Console.WriteLine($"Account 3 after transfer: Balance = {account3.Balance}, Transfer successful: {transferSuccess}");
Console.WriteLine($"Account 1 after receiving transfer: {account1.Balance}");

// Apply Interest
Console.WriteLine("Applying interest to Account 1...");
account1.ApplyInterest();
Console.WriteLine($"Account 1 after applying interest: Balance: {account1.Balance}");

// Step 3: Display customer and account information
Console.WriteLine("\nDisplaying customer and account information...");
Console.WriteLine(customer1.DisplayCustomerInfo());
Console.WriteLine(account1.DisplayAccountInfo());