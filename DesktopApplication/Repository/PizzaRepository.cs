using DesktopApplication.Model;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class PizzaRepository
{
    private static List<Pizza> Pizzas { get; } = new()
    {
        new Pizza("Pepperoni Feast", 18.99),
        new Pizza("Loaded Pepperoni Feast with Triple Cheese Blend", 20.99),
        new Pizza("Margherita", 14.99),
        new Pizza("Loaded Margherita with Triple Cheese Blend", 16.99),
        new Pizza("Loaded Chicken Supreme with Triple Cheese Blend", 20.99),
        new Pizza("Hawaiian", 17.99),
        new Pizza("Loaded Hawaiian with Triple Cheese Blend", 19.99),
        new Pizza("Meat Feast", 18.99),
        new Pizza("The Meaty One", 20.99),
        new Pizza("Farmhouse", 19.99),
        new Pizza("Texan BBQ", 20.99),
        new Pizza("BBQ Meat Feast", 20.99),
        new Pizza("Veggie Sizzler", 18.99),
        new Pizza("Beef Sizzler", 20.99),
        new Pizza("Chicken Sizzler", 20.99),
        new Pizza("Supreme", 20.99),
        new Pizza("Vegetable Supreme", 18.99),
        new Pizza("Chicken Supreme", 20.99)
    };

    public static void Create(Pizza pizza) => Pizzas.Add(pizza);

    public static void CreateAll(List<Pizza> pizzas)
    {
        foreach (var pizza in pizzas)
        {
            Pizzas.Add(pizza);
        }
        // Pizzas.AddRange(pizza);
    }


    public static Pizza Read(int id) => Pizzas[id];

    public static List<Pizza> ReadAll() => Pizzas;


    public static void Update(int id, Pizza pizza) => Pizzas[id] = pizza;


    public static void Delete(int id) => Pizzas.RemoveAt(id);

    public static void Delete(Pizza pizza) => Pizzas.Remove(pizza);

    public static void DeleteAll() => Pizzas.Clear();
}