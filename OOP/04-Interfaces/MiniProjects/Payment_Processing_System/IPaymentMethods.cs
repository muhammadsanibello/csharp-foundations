using System;

namespace Payment_Processing_System
{
    public interface IPaymentMethod
    {
        // Method to pay money
        void Pay(decimal amount);

        // Method to refund money
        void Refund(decimal amount);
    }
}
