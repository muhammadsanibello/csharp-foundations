using System;

namespace E_Commerce_Order_Management_System
{
    public class ExpressShipping : IShippingService
    {
        public void ShipOrder()
        {
            Console.WriteLine("Order shipped via Express delivery.\nEstimated delivery: 24 hours");
        }

        public void TrackShipment()
        {
            Console.WriteLine("Package is currently in Abuja distribution center");
        }
    }
}
