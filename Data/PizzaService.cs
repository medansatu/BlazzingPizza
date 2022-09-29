namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<List<PizzaData>> GetPizzasAsync()
    {
        var pizzaData = new List<PizzaData>()
        {
            new PizzaData { PizzaId = 1, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian =false },
            new PizzaData { PizzaId = 2, Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Vegan = false, Vegetarian =false},
            new PizzaData { PizzaId = 3, Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza", Vegan = true, Vegetarian =true},
            new PizzaData { PizzaId = 4, Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", Vegan = false, Vegetarian =true},
            new PizzaData { PizzaId = 5, Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", Vegan = false, Vegetarian =false},
            new PizzaData { PizzaId = 6, Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", Vegan = false, Vegetarian =true}  
        };
        return pizzaData;
    }
}