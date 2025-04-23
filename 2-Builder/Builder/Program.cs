using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber Jose = new Subscriber("jose", "jose@a.com");
            Subscriber Maria = new Subscriber("Maria", "Maria@a.com");
            Subscriber Joao = new Subscriber("Joao", "Joao@a.com");

            Publisher publisher = new Publisher();

            publisher.addSubscriber(Jose);
            publisher.addSubscriber(Maria);
            publisher.addSubscriber(Joao);

            publisher.Notify();

        }
    }
}
