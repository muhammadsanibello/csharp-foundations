using Payment_Processing_System;

// Interface variable
IPaymentMethod payment;

// Card payment
payment = new CardPayment();

// Payment manager / system
PaymentManager manager = new PaymentManager(payment);

manager.ProcessPayment(5000);
manager.ProcessRefund(5000);
manager.ShowHistory();

payment = new CashPayment();
PaymentManager manager1 = new PaymentManager(payment);

manager1.ProcessPayment(400);
manager1.ProcessRefund(400);
manager1.ShowHistory();

payment = new USSDPayment();
PaymentManager manager2 = new PaymentManager(payment);
manager2.ProcessPayment(5000);
manager2.ProcessRefund(5000);
manager2.ShowHistory();