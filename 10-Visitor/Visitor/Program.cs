namespace VisitorPatternExample
{
    using System;
    using System.Collections.Generic;

    // Visitor interface
    public interface IVisitor
    {
        void VisitMenu(Menu menu);
        void VisitMenuItem(MenuItem menuItem);
        void VisitIngredient(Ingredient ingredient);
    }

    // Element interface
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    // Concrete Elements
    public class Menu : IVisitable
    {
        public List<IVisitable> Items { get; } = new List<IVisitable>();
        public string Name { get; }

        public Menu(string name)
        {
            Name = name;
        }

        public void AddItem(IVisitable item)
        {
            Items.Add(item);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitMenu(this);
            foreach (var item in Items)
            {
                item.Accept(visitor);
            }
        }
    }

    public class MenuItem : IVisitable
    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();

        public MenuItem(string name)
        {
            Name = name;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitMenuItem(this);
            foreach (var ingredient in Ingredients)
            {
                ingredient.Accept(visitor);
            }
        }
    }

    public class Ingredient : IVisitable
    {
        public string Name { get; }
        public int Calories { get; }
        public int Protein { get; }
        public int Carbs { get; }

        public Ingredient(string name, int calories, int protein, int carbs)
        {
            Name = name;
            Calories = calories;
            Protein = protein;
            Carbs = carbs;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitIngredient(this);
        }
    }

    // Concrete Visitor
    public class NutritionVisitor : IVisitor
    {
        public int TotalCalories { get; private set; }
        public int TotalProtein { get; private set; }
        public int TotalCarbs { get; private set; }

        public void VisitMenu(Menu menu)
        {
            Console.WriteLine($"Visiting Menu: {menu.Name}");
        }

        public void VisitMenuItem(MenuItem menuItem)
        {
            Console.WriteLine($"  Visiting Menu Item: {menuItem.Name}");
        }

        public void VisitIngredient(Ingredient ingredient)
        {
            Console.WriteLine($"    Visiting Ingredient: {ingredient.Name} (Calories: {ingredient.Calories}, Protein: {ingredient.Protein}, Carbs: {ingredient.Carbs})");
            TotalCalories += ingredient.Calories;
            TotalProtein += ingredient.Protein;
            TotalCarbs += ingredient.Carbs;
        }
    }

    // Client
    class Program
    {
        static void Main()
        {
            // Criar ingredientes
            Ingredient egg = new Ingredient("Egg", 70, 6, 1);
            Ingredient bacon = new Ingredient("Bacon", 100, 7, 0);
            Ingredient pancake = new Ingredient("Pancake", 150, 4, 20);

            // Criar menu items
            MenuItem breakfastSpecial = new MenuItem("Breakfast Special");
            breakfastSpecial.AddIngredient(egg);
            breakfastSpecial.AddIngredient(bacon);

            MenuItem sweetBreakfast = new MenuItem("Sweet Breakfast");
            sweetBreakfast.AddIngredient(pancake);

            // Criar menu
            Menu breakfastMenu = new Menu("Breakfast Menu");
            breakfastMenu.AddItem(breakfastSpecial);
            breakfastMenu.AddItem(sweetBreakfast);

            // Criar Visitor
            NutritionVisitor nutritionVisitor = new NutritionVisitor();

            // Aplicar o Visitor
            breakfastMenu.Accept(nutritionVisitor);

            Console.WriteLine("\nTotal Nutritional Information:");
            Console.WriteLine($"Calories: {nutritionVisitor.TotalCalories}");
            Console.WriteLine($"Protein: {nutritionVisitor.TotalProtein}g");
            Console.WriteLine($"Carbs: {nutritionVisitor.TotalCarbs}g");
        }
    }
}
