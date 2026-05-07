using System;

namespace Shopping_Cart_System
{
    public class CartItem
    {

        public Product SelectedProduct { get; private set; }
        public int Quantity { get; private set; }

        public CartItem(Product product, int quantity)
        {
            if (product == null)
            {
                Console.WriteLine("Product cannot be empty");
                return;
            }

            if (quantity > product.Stock)
            {
                Console.WriteLine("Insuffient product!");
                return;
            }

            SelectedProduct = product;
            Quantity = quantity;
        }
    }
}
