using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentService
    {
        private int ammount;
        private bool includeDelivery;
        public PaymentService(int ammount, bool includeDelivery)
        {
            this.ammount = ammount;
            this.includeDelivery = includeDelivery; 
        }

        public void ProcessOrder(IPaymentStrategy strategy)
        {
            int total = this.CalculateTotal();
            strategy.Pay(ammount);
        }

        private int CalculateTotal()
        {
            return this.includeDelivery ? this.ammount + 10 : this.ammount;
        }
    }
}
