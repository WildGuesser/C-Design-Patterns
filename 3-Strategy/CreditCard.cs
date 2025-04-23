using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CreditCard
    {
        private int balance = 1000;
        private string cardNumber;

        public CreditCard(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void Deduct(int ammount)
        {
            if (ammount > this.balance) throw new Exception("Fundos insuficientes");
            this.balance -= ammount;
        }

        public int GetBalance()
        {
            return this.balance;
        }
    }
}
