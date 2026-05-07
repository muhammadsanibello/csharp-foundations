// Shopping Cart System

using Shopping_Cart_System;

// Product objects
var product1 = new Product("Phone", 200000, 30);
var product2 = new Product("Laptop", 300000, 20);
var product3 = new Product("Watch", 100000, 10);

// CartItem objects
var item1 = new CartItem(product1, 20);
var item2 = new CartItem(product2, 10);
var item3 = new CartItem(product3, 5);

// Shopping Cart object
var shoppingCart = new ShoppingCart();

// Add items into shoppingCart
shoppingCart.AddItem(item1);
shoppingCart.AddItem(item2);
shoppingCart.AddItem(item3);

// Checkout
shoppingCart.CheckOut();

// Testing the remaining stock of product1
Console.WriteLine(product1.Stock);