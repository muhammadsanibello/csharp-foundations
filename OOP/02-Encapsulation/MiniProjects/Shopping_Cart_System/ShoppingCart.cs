using System;

namespace Shopping_Cart_System
{
    public class ShoppingCart
    {

        private CartItem[] listOfItems;
        private int ItemCount;

        public ShoppingCart()
        {
            // Maximum of 30 items
            listOfItems = new CartItem[30];
            ItemCount = 0;
        }

        public void AddItem(CartItem item)
        {
            if (ItemCount < 30)
            {
                listOfItems[ItemCount] = item;
                ItemCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more items.");
            }

        }

        public void CheckOut()
        {
            // Total Price
            decimal totalPrice = 0;

            for (int i = 0; i < ItemCount; i++)
            {
                totalPrice += (listOfItems[i].Quantity * listOfItems[i].SelectedProduct.Price);
            }

            Console.WriteLine($"Total Price = {totalPrice}");

            // Reducing the stock
            for (int i = 0; i < ItemCount; i++)
            {
                listOfItems[i].SelectedProduct.Stock -= listOfItems[i].Quantity;
            }

            // Clearing the cart
            Array.Clear(listOfItems);
        }

    }
}
