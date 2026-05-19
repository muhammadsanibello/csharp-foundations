using System;

namespace E_Commerce_Order_Management_System
{
    public class OrderManager
    {
        private Order _order;

        public OrderManager(Order order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            _order.ProcessOrder();
        }

        public void TrackShipment()
        {
            _order.ShippingService.TrackShipment();
        }

        public void DisplaySummary()
        {
            _order.DisplayOrderSummary();
        }
    }
}
