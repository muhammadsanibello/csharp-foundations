using System;

namespace Payment_Processing_System
{
    public class USSDPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"USSD payment of N{amount:F2} has successful");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refund of N{amount:F2} received via USSD");
        }
    }
}
