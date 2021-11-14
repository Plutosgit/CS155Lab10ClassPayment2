using System;

namespace CS155Lab10ClassPayment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lab10 Inheritance and Overriding base class functions!");

            Payment p1 = new Payment(432.88);
            Payment p2 = new Payment(1560.97);

            p1.PaymentAmount =765.84;
            p2.PaymentAmount = 345.01;

            p1.PaymentDetails();
            p2.PaymentDetails();

            CashPayment Cp1 = new CashPayment(107.98);
            CashPayment Cp2 = new CashPayment(234.56);

            Cp1.PaymentDetails();
            Cp2.PaymentDetails();

            CreditCardPayment CCp1 = new CreditCardPayment(120.34, "Jane Smith", "9876-5432-1012-3456");
            CreditCardPayment CCp2 = new CreditCardPayment(22.56, "John Smith", "1023-4567-8901-2345");

            CCp1.PaymentDetails();
            CCp2.PaymentDetails();

        }
    }
}
