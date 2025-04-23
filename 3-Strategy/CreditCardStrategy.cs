using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Strategies concretas
    public class CreditCardStrategy : IPaymentStrategy
    {
        private CreditCard _creditCard;
        public CreditCardStrategy(CreditCard card)
        {
            _creditCard = card;
        }

        public void Pay(int ammount)
        {
            this._creditCard.Deduct(ammount);
            Console.WriteLine($"Paid {ammount} euros via CreditCard. New balance: {this._creditCard.GetBalance()}");
        }
    }
}
