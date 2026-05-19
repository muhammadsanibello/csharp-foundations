using E_Commerce_Order_Management_System;

// Product objects
var product1 = new Product("Phone", 200000, 1000);
var product2 = new Product("Laptop", 300000, 100);
var product3 = new Product("Watch", 50000, 50);

// Customer objects
var customer1 = new Customer("Sani Bello", "muhammadsanib13@gmail.com");
var customer2 = new Customer("Ahmad Usman", "ahmad@yandex.ru");

// Payment methods objects
IPaymentMethod payment1 = new CardPayment();
IPaymentMethod payment2 = new CashPayment();

// Shipping services methods
IShippingService shipping1 = new ExpressShipping();
IShippingService shipping2 = new StandardShipping();

// Order object
Order order1 = new OnlineOrder(customer1, product1, 100, payment1, shipping1);
Order order2 = new StorePickupOrder(customer2, product2, 50, payment2, shipping2);

order1.DisplayOrderSummary();
order2.DisplayOrderSummary();

// Order manager object
OrderManager manager1 = new OrderManager(order1);
manager1.DisplaySummary();

manager1.ProcessOrder();
manager1.TrackShipment();