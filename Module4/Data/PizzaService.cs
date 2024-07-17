namespace Module4.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        Pizza[] pizzaArrayList = new Pizza[]
            {
                new Pizza { PizzaId = 1, Name = "Margherita", Description = "Classic Margherita with tomatoes, mozzarella, and basil", Price = 8.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Description = "Pepperoni, mozzarella, and tomato sauce", Price = 9.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 3, Name = "Veggie", Description = "Mixed vegetables with mozzarella and tomato sauce", Price = 10.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 4, Name = "BBQ Chicken", Description = "Grilled chicken with BBQ sauce, red onions, and cilantro", Price = 11.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 5, Name = "Hawaiian", Description = "Ham, pineapple, and mozzarella", Price = 10.49m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 6, Name = "Buffalo Chicken", Description = "Buffalo chicken, blue cheese, and mozzarella", Price = 12.49m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 7, Name = "Meat Lover's", Description = "Pepperoni, sausage, ham, bacon, and mozzarella", Price = 13.49m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 8, Name = "Cheese", Description = "Classic cheese pizza with mozzarella and tomato sauce", Price = 7.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 9, Name = "Mushroom", Description = "Mushrooms, garlic, and mozzarella", Price = 9.49m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 10, Name = "Spinach Alfredo", Description = "Spinach with Alfredo sauce and mozzarella", Price = 11.49m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 11, Name = "Four Cheese", Description = "Mozzarella, cheddar, Parmesan, and blue cheese", Price = 12.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 12, Name = "Sausage", Description = "Italian sausage, red peppers, and mozzarella", Price = 10.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 13, Name = "Greek", Description = "Olives, feta cheese, tomatoes, and red onions", Price = 11.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 14, Name = "Caprese", Description = "Fresh mozzarella, tomatoes, basil, and balsamic glaze", Price = 12.49m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 15, Name = "Pesto", Description = "Pesto sauce, mozzarella, and cherry tomatoes", Price = 11.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 16, Name = "Taco Pizza", Description = "Ground beef, cheddar cheese, lettuce, and tomatoes", Price = 13.49m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 17, Name = "Bacon Cheeseburger", Description = "Ground beef, bacon, cheddar cheese, and pickles", Price = 13.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 18, Name = "Artichoke", Description = "Artichoke hearts, spinach, and mozzarella", Price = 11.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 19, Name = "Truffle Mushroom", Description = "Truffle oil, mushrooms, and mozzarella", Price = 14.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 20, Name = "Prosciutto", Description = "Prosciutto, arugula, and Parmesan cheese", Price = 14.49m, Vegetarian = false, Vegan = false }
            };

        return Task.FromResult<Pizza[]>(pizzaArrayList);
    }
}