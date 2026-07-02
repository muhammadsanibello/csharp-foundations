using System;

namespace Inventory_System
{
    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; }

        public ProductEventArgs(Product product)
        {
            Product = product;
        }
    }
}