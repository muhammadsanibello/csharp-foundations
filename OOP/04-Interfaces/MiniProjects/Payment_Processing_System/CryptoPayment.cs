using System;

namespace Payment_Processing_System
{
    public class CryptoPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Crypto payment of N{amount:F2} successful.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refund N{amount:F2} to wallet.");
        }
    }
}
