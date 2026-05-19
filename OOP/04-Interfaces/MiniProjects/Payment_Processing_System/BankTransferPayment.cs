using System;

namespace Payment_Processing_System
{
    public class BankTransferPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Transfer of N{amount:F2} received.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refund of N{amount:F2} approved.");
        }
    }
}
