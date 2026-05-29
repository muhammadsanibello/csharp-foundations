using System;

namespace Shopping_Cart_System
{
    public class ShoppingCart
    {

        private HashSet<CartItem> _items;

        public ShoppingCart()
        {
            _items = new HashSet<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        public decimal CheckOut()
        {
            // Total Price
            decimal totalPrice = 0;

            if (_items.Count == 0)
            {
                return totalPrice = 0;
            }

            foreach (var item in _items)
            {
                totalPrice += item.SelectedProduct.Price * item.Quantity;
                item.SelectedProduct.ReduceStock(item.Quantity);
            }

            //  Clear the cart
            _items.Clear();

            return totalPrice;
        }

    }
}
