using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_plus_Dependency_Injection
{
    public class VeggieFactory : BurgerFactory
    {
        public override IBurger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}
