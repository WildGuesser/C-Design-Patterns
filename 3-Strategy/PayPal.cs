using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PayPal
    {
        private int Balance { get; set; } = 1000;
        private string email;

        public PayPal(string email)
        {
            this.email = email.ToLower();
        }
        public void Deduct(int ammount)
        {

            if (ammount > this.Balance) throw new Exception("Fundos insuficientes");
            this.Balance -= ammount;
        }

        public int GetBalance()
        {
            return this.Balance;
        }
    }
}
