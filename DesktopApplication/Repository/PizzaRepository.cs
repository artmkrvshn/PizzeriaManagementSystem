using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DesktopApplication.Model;

namespace DesktopApplication.Repository;

public static class PizzaRepository
{
    public static ObservableCollection<Pizza> Pizzas { get; } = new()
    {
        new Pizza("Pepperoni Feast", ReadIngredients(new[]
            { "Tomato Sauce", "Extra Mozzarella Cheese", "Pepperoni", "Pepperoni" })),

        new Pizza("Loaded Pepperoni Feast with Triple Cheese Blend", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Pepperoni", "Pepperoni", "Triple Cheese Blend" })),

        new Pizza("Margherita", ReadIngredients(new[]
            { "Tomato Sauce", "Extra Mozzarella Cheese" })),

        new Pizza("Loaded Margherita with Triple Cheese Blend", ReadIngredients(new[]
            { "Tomato Sauce", "Extra Mozzarella Cheese", "Triple Cheese Blend" })),

        new Pizza("Loaded Chicken Supreme with Triple Cheese Blend", ReadIngredients(new[]
        {
            "Tomato Sauce", "Mozzarella Cheese", "Chicken", "Mushrooms", "Mixed Peppers", "Red Onions",
            "Triple Cheese Blend"
        })),


        new Pizza("Hawaiian", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Ham", "Pineapple", })),

        new Pizza("Loaded Hawaiian with Triple Cheese Blend", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Ham", "Pineapple", "Triple Cheese Blend" })),

        new Pizza("Meat Feast", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Spicy Pork", "Ham", "Pepperoni", "Seasoned Minced Beef" })),

        new Pizza("The Meaty One", ReadIngredients(new[]
        {
            "Tomato Sauce", "Mozzarella Cheese", "Spicy Pork", "Pepperoni", "Seasoned Minced Beef", "Smoked Bacon",
            "Chicken"
        })),

        new Pizza("Farmhouse", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Ham", "Mushrooms" })),

        new Pizza("Texan BBQ", ReadIngredients(new[]
            { "BBQ Sauce", "Mozzarella Cheese", "Smoked Bacon", "Chicken" })),

        new Pizza("BBQ Meat Feast", ReadIngredients(new[]
            { "BBQ Sauce", "Mozzarella Cheese", "Spicy Pork", "Ham", "Pepperoni", "Seasoned Minced Beef" })),

        new Pizza("Veggie Sizzler", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Green Chillies", "Jalapeños", "Mixed Peppers", "Red Onions" })),

        new Pizza("Beef Sizzler", ReadIngredients(new[]
        {
            "Tomato Sauce", "Mozzarella Cheese", "Green Chillies", "Jalapeños", "Seasoned Minced Beef", "Red Onions"
        })),

        new Pizza("Chicken Sizzler", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Green Chillies", "Jalapeños", "Chicken", "Red Onions" })),

        new Pizza("Supreme", ReadIngredients(new[]
        {
            "Tomato Sauce", "Mozzarella Cheese", "Pepperoni", "Seasoned Minced Beef", "Spicy Pork", "Mushrooms",
            "Mixed Peppers", "Red Onions"
        })),

        new Pizza("Vegetable Supreme", ReadIngredients(new[]
            { "Tomato Sauce", "Mozzarella Cheese", "Mushrooms", "Mixed Peppers", "Red Onions", "Tomato" })),

        new Pizza("Chicken Supreme", ReadIngredients(new[] 
            { "Tomato Sauce", "Mozzarella Cheese", "Chicken", "Mushrooms", "Mixed Peppers", "Red Onions" }))
    };

    private static ObservableCollection<Ingredient> ReadIngredients(string[] names)
    {
        return new ObservableCollection<Ingredient>(IngredientRepository.Read(names));
    }

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

    public static ObservableCollection<Pizza> ReadAll() => Pizzas;


    public static void Update(int id, Pizza pizza) => Pizzas[id] = pizza;


    public static void Delete(int id) => Pizzas.RemoveAt(id);

    public static void Delete(Pizza pizza) => Pizzas.Remove(pizza);

    public static void DeleteAll() => Pizzas.Clear();

}