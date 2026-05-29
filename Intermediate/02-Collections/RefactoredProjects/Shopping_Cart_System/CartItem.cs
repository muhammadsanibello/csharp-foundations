using System;

namespace Shopping_Cart_System
{
    public class CartItem
    {

        public Product SelectedProduct { get; private set; }
        public int Quantity { get; private set; }

        public CartItem(Product product, int quantity)
        {
            if (quantity > product.Stock) throw new ArgumentException(nameof(quantity), "Insufficient products");

            SelectedProduct = product;
            Quantity = quantity;
        }
    }
}
