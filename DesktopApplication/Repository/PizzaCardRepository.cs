using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DesktopApplication.Model;

namespace DesktopApplication.Repository;

public static class PizzaCardRepository
{
    private static List<PizzaCard> PizzaCards { get; } = new()
    {
        new PizzaCard(PizzaRepository.Read(0),
            "Double Pepperoni, Extra Mozzarella Cheese",
            "pepperoni-feast.jpg"),

        new PizzaCard(PizzaRepository.Read(1), 
            "Now With Even More Pepperoni, Mozzarella And Triple Cheese Blend",
            "loaded-pepperoni-feast.jpg"),

        new PizzaCard(PizzaRepository.Read(2), 
            "Mozzarella Cheese, Tomato Sauce", 
            "margherita.jpg"),

        new PizzaCard(PizzaRepository.Read(3), 
            "Now With Even More Mozzarella, Tomato Sauce And Triple Cheese Blend",
            "loaded-margherita.jpg"),

        new PizzaCard(PizzaRepository.Read(4),
            "Now With Even More Chicken, Mushrooms, Mixed Peppers, Red Onions And Triple Cheese Blend",
            "loaded-chicken-supreme.jpg"),

        new PizzaCard(PizzaRepository.Read(5), 
            "Ham, Pineapple", 
            "hawaiian.jpg"),

        new PizzaCard(PizzaRepository.Read(6), 
            "Now With Even More Ham, Pineapple And Triple Cheese Blend",
            "loaded-hawaiian.jpg"),

        new PizzaCard(PizzaRepository.Read(7), 
            "Spicy Pork, Ham, Pepperoni, Seasoned Minced Beef", 
            "meat-feast.jpg"),

        new PizzaCard(PizzaRepository.Read(8), 
            "Pepperoni, Spicy Pork, Seasoned Minced Beef, Smoked Bacon, Chicken",
            "meaty-one.jpg"),

        new PizzaCard(PizzaRepository.Read(9), 
            "Ham, Mushrooms", 
            "farmhouse.jpg"),

        new PizzaCard(PizzaRepository.Read(10), 
            "BBQ Sauce, Smoked Bacon, Chicken", 
            "texan-bbq.jpg"),

        new PizzaCard(PizzaRepository.Read(11), 
            "BBQ Sauce, Spicy Pork, Ham, Pepperoni, Seasoned Minced Beef",
            "bbq-meatfeast.jpg"),

        new PizzaCard(PizzaRepository.Read(12),
            "Green Chillies, Jalapeños, Mixed Peppers, Roquito Peppers, Red Onions", 
            "veg-sizzler.jpg")
    };

    public static void Create(PizzaCard pizzaCard) => PizzaCards.Add(pizzaCard);

    public static void CreateAll(List<PizzaCard> pizzaCards)
    {
        foreach (var pizzaCard in pizzaCards)
        {
            PizzaCards.Add(pizzaCard);
        }
        // PizzaCards.AddRange(pizzaCard);
    }


    public static PizzaCard Read(int id) => PizzaCards[id];

    public static List<PizzaCard> ReadAll() => PizzaCards;


    public static void Update(int id, PizzaCard pizzaCard) => PizzaCards[id] = pizzaCard;


    public static void Delete(int id) => PizzaCards.RemoveAt(id);

    public static void Delete(PizzaCard pizzaCard) => PizzaCards.Remove(pizzaCard);

    public static void DeleteAll() => PizzaCards.Clear();
}