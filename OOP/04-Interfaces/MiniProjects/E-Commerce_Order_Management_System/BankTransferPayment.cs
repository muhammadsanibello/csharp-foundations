using System;

namespace E_Commerce_Order_Management_System
{
    public class BankTransferPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Transfer of N{amount:F2} recieved");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Transfer of N{amount:F2} has been refunded");
        }
    }
}
