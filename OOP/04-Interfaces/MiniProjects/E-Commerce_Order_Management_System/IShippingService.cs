using System;

namespace E_Commerce_Order_Management_System
{
    public interface IShippingService
    {
        // Method to ship an order
        void ShipOrder();

        // Method to track ship
        void TrackShipment();
    }
}
