using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Strategy Interface
    public interface IPaymentStrategy
    {
        public void Pay(int ammount);
    }
}
