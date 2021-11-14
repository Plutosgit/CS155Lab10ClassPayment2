using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Lab10ClassPayment2
{
    public class CreditCardPayment:Payment
    {
        private string nameonthecard;
        private string cardnumber;
        public CreditCardPayment() { }
        public CreditCardPayment(double p, string name, string number) : base(p)
        {
            
            nameonthecard = name;
            cardnumber = number;
        }

        public string NameonCard{ get => nameonthecard; set => nameonthecard = value; }
        public string CardNumber{ get => cardnumber; set => cardnumber = value; }
        public void PaymentDetails() { 
            Console.WriteLine("Name on the Card: " + NameonCard + 
                            "\nCard Number     : " + CardNumber + 
                            "\nPayment amount  : " + PaymentAmount.ToString()); 
        }


    }
}
