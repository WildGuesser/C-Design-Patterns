using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Subscriber : IEventListener
    {

        public string nome;
        public string email;

        public Subscriber(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
        public void Update()
        {
            Console.WriteLine($"notificar {this.email}");
        }
    }
}
