using System;

namespace E_Commerce_Order_Management_System
{
    public class StandardShipping : IShippingService
    {
        public void ShipOrder()
        {
            Console.WriteLine("Order shipped via standard delivery.\nEstimated delivery: 5 days");
        }

        public void TrackShipment()
        {
            Console.WriteLine("Package is in transit to Kano");
        }
    }
}