using System;

namespace E_Commerce_Order_Management_System
{
    public class StorePickupOrder : Order
    {
        public StorePickupOrder(Customer customer, Product product, int totalAmount, IPaymentMethod paymentMethod, IShippingService shippingService) : base(customer, product, totalAmount, paymentMethod, shippingService)
        {
        }

        public override void ProcessOrder()
        {
            decimal total = CalculateTotal();

            bool reduceSuccess = product.ReduceStock(TotalAmount);

            if (reduceSuccess)
            {
                PaymentMethod.Pay(total);
            }
            else
            {
                Console.WriteLine("Insufficient stock");
            }
        }
    }
}
