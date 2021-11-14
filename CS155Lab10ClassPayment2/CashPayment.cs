using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Lab10ClassPayment2
{
    //class CashPayment
    public class CashPayment:Payment
    {
        public CashPayment() { }
        public CashPayment(double p) : base(p) { }

        public void PaymentDetails()
        {
            Console.WriteLine("The details of payment IN CASH: " + PaymentAmount.ToString());
        }
    }
}
