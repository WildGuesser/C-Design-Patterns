using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_plus_Dependency_Injection
{
    public abstract class BurgerFactory
    {
        public IBurger OrderBurger()
        {
            IBurger burger = this.CreateBurger();
            burger.Prepare();
            return burger;
        }

        public abstract IBurger CreateBurger();

    }
}
