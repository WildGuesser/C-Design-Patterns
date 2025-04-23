namespace Bridge
{
    public abstract class Pizza
    {
        public string sauce { get; set; }
        public string toppings { get; set; }

        public abstract void assemble();
    }

    public class PepperoniPizza : Pizza
    {
        public override void assemble()
        {
            Console.WriteLine($"Adding {sauce}");
            Console.WriteLine($"Adding {toppings}");
        }
    }

    public class VeggiePizza : Pizza
    {
        public override void assemble()
        {
            Console.WriteLine($"Adding {sauce}");
            Console.WriteLine($"Adding {toppings}");
        }
    }

    // estamos a desacopolar a abstração da Implementação
    public abstract class Restaurant
    {
        protected Pizza pizza;

        protected Restaurant(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public abstract void AddSauce();
        public abstract void AddToppings();

        public abstract void deliver();

    }
    public class AmericanRestaurant : Restaurant
    {
        public AmericanRestaurant(Pizza pizza) : base(pizza) { }

        public override void AddSauce()
        {
            pizza.sauce = "Tomato Sauce";
        }

        public override void AddToppings()
        {
            pizza.toppings = "Bacon";
        }

        public override void deliver()
        {
            AddSauce();
            AddToppings();
            this.pizza.assemble();
            Console.WriteLine("A entregar");
        }
    }


    public class ItalianRestaurant : Restaurant
    {
        public ItalianRestaurant(Pizza pizza) : base(pizza) { }

        public override void AddSauce()
        {
            pizza.sauce = "Avocato Sauce";
        }

        public override void AddToppings()
        {
            pizza.toppings = "some other topping";
        }

        public override void deliver()
        {
            AddSauce();
            AddToppings();
            this.pizza.assemble();
            Console.WriteLine("A entregar");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Restaurant american = new AmericanRestaurant(new PepperoniPizza());
            Restaurant italian = new ItalianRestaurant(new VeggiePizza());

            italian.deliver();
        }
    }
}
