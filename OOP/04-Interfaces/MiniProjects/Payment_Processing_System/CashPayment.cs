using System;

namespace Payment_Processing_System
{
    public class CashPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash payment of N{amount:F2} received.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Cash refund of N{amount:F2} given.");
        }
    }
}
