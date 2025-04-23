using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_plus_Dependency_Injection
{
    public class VeggieBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("A preparar um Veggie Burger");
        }
    }


}
