using System;

namespace E_Commerce_Order_Management_System
{
    public class CashPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash payment of N{amount:F2} has successful.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Cash refund of N{amount:F2} received");
        }
    }
}
