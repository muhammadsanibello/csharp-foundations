using System;

namespace E_Commerce_Order_Management_System
{
    public class OnlineOrder : Order
    {
        public OnlineOrder(Customer customer, Product product, int totalAmount, IPaymentMethod paymentMethod, IShippingService shippingService) : base(customer, product, totalAmount, paymentMethod, shippingService)
        {
        }

        public override void ProcessOrder()
        {
            decimal total = CalculateTotal();

            bool reduceSuccess = product.ReduceStock(TotalAmount);

            if (!reduceSuccess)
            {
                Console.WriteLine("Insufficent stock");
                return;
            }

            PaymentMethod.Pay(total);

            ShippingService.ShipOrder();
        }
    }
}
