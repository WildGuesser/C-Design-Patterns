namespace Factory_plus_Dependency_Injection
{

    internal class Program
    {
        static void Main(string[] args)
        {
            VeggieFactory veggieRestaurant = new VeggieFactory();
            BeefBurgerFactory beefRestaurant = new BeefBurgerFactory();

            IBurger veggieBurger = veggieRestaurant.OrderBurger();
            IBurger beffBurger = beefRestaurant.OrderBurger();

        }
    }
}
