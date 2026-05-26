public abstract class Account
{
    public decimal Balance { get; set; }

    public decimal CheckBalance()
    {
        return Balance;
    }
}

public class CheckingAccount : Account
{
}

public class SavingsAccount : Account
{
}

class Program
{
    static void Main()
    {
        Account account1 = new CheckingAccount();
        Account account2 = new SavingsAccount();

        // cast object using 'is' keyword with pattern matching
        if (account1 is CheckingAccount checkingAccount)
        {
            // Use checkingAccount as CheckingAccount
        }

        // using 'is' keyword followed by explicit casting
        if (account2 is SavingsAccount)
        {
            SavingsAccount savingsAccount = (SavingsAccount)account2;
            // Use savingsAccount as SavingsAccount
        }

        // cast object using 'as' keyword
        CheckingAccount checkingAccount1 = account1 as CheckingAccount;

        if (checkingAccount1 != null)
        {
            // Use checkingAccount1 as CheckingAccount
        }
    }
}