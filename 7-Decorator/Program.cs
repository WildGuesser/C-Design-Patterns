using System;

namespace Decorator
{
    public abstract class Coffee
    {
        public string description = "Unknown Coffee";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }

    public class Espresso : Coffee
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    public abstract class CoffeeDecorator : Coffee
    {
        public abstract override string getDescription();
    }

    public class WithMilk : CoffeeDecorator
    {
        Coffee coffee;

        public WithMilk(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public override double cost()
        {
            return coffee.cost() + 0.5;
        }

        public override string getDescription()
        {
            return coffee.getDescription() + ", with Milk";
        }
    }

    public class WithSugar : CoffeeDecorator
    {
        Coffee coffee;

        public WithSugar(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public override double cost()
        {
            return coffee.cost() + 0.25;
        }

        public override string getDescription()
        {
            return coffee.getDescription() + ", with Sugar";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee espresso = new Espresso();
            espresso = new WithMilk(espresso);
            espresso = new WithSugar(espresso);
            PrintCoffee(espresso);
        }

        private static void PrintCoffee(Coffee coffee)
        {
            Console.WriteLine($"Cost: {coffee.cost()} , Description: {coffee.getDescription()}");
        }
    }
}
