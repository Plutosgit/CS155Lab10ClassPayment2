using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Lab10ClassPayment2
{
    public class Payment
    {
        private double paymentamount;

        //constructors
        public Payment()
        {
            paymentamount = 0.0;
        }
        public Payment(double p)
        {
            paymentamount = p;
        }

        public double PaymentAmount { get => paymentamount; set => paymentamount = value; }
        public void PaymentDetails() { Console.WriteLine("The amount of payment: " + paymentamount.ToString()); }

        
    }
}
