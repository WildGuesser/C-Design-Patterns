using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PayPalStrategy : IPaymentStrategy
    {
        private PayPal _payPal;
        public PayPalStrategy(PayPal payPal)
        {
            _payPal = payPal;
        }

        public void Pay(int ammount)
        {
            this._payPal.Deduct(ammount);
            Console.WriteLine($"Paid {ammount} euros via PayPal. New balance: {this._payPal.GetBalance()}");
        }
    }
}
