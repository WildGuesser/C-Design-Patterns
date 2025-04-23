using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber : IEventListener
    {
        public string name;
        public string email;

        public Subscriber(string name, string email) { 
            this.name = name;
            this.email = email; 
        } 

        public void Update() {

            Console.WriteLine($"notificar: {this.email}");
        }    

    }
}
