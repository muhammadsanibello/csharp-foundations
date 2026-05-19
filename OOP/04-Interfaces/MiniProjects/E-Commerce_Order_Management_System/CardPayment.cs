using System;

namespace E_Commerce_Order_Management_System
{
    public class CardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Card payment of N{amount:F2} has successful.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refund of N{amount:F2} recieved by card");
        }
    }
}
