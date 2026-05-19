using System;

namespace Payment_Processing_System
{
    public class PaymentManager
    {
        private IPaymentMethod _paymentMethod;
        private string[] _transactionHistory;
        private int _transactionCount;

        public PaymentManager(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
            _transactionHistory = new string[100];
            _transactionCount = 0;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.Pay(amount);

            // Add to history
            AddTransaction($"Paid. Amount: N{amount:F2}");
        }

        public void ProcessRefund(decimal amount)
        {
            _paymentMethod.Refund(amount);

            // Add to history
            AddTransaction($"Refunded. Amount: N{amount:F2}");
        }

        private void AddTransaction(string details)
        {
            // Prevent going out of bound
            if (_transactionCount >= 100)
            {
                Console.WriteLine("History log is full.");
                return;
            }

            _transactionHistory[_transactionCount] = details;
            _transactionCount++;
        }

        public void ShowHistory()
        {
            Console.WriteLine("--- Transactions History ---");
            
            for (int i = 0; i < _transactionCount; i++)
            {
                Console.WriteLine($"{i + 1}. {_transactionHistory[i]}");
            }
        }
    }
}