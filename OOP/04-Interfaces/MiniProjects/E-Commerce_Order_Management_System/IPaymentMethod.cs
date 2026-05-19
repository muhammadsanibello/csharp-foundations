using Microsoft.VisualBasic;
using System;

namespace E_Commerce_Order_Management_System
{
    public interface IPaymentMethod
    {
        // Method to pay money
        void Pay(decimal amount);

        // Method to refund money
        void Refund(decimal amount);
    }
}
