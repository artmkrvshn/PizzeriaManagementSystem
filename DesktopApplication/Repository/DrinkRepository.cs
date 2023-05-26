using DesktopApplication.Model;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class DrinkRepository
{
    private static List<Drink> Drinks { get; } = new()
    {
        new Drink("Pepsi Max  (1.5L)", 2.49, 1500),
        new Drink("Pepsi Max (500ml)", 1.49, 500),
        new Drink("Pepsi Max Cherry (1.5L)", 2.49, 1500),
        new Drink("Pepsi Diet (1.5L)", 2.49, 1500),
        new Drink("Pepsi Diet (500ml)", 1.49, 500),
        new Drink("7up Free (1.5L)", 2.49, 1500),
        new Drink("7up Free (500ml)", 1.49, 500),
        new Drink("Pepsi (1.5L)", 2.92, 1500),
        new Drink("Pepsi (500ml)", 1.63, 500),
        new Drink("Bottled Water (500ml)", 1.29, 500)
    };

    public static void Create(Drink drink) => Drinks.Add(drink);

    public static void CreateAll(List<Drink> drinks)
    {
        foreach (var drink in drinks)
        {
            Drinks.Add(drink);
        }
        // Pizzas.AddRange(pizza);
    }


    public static Drink Read(int id) => Drinks[id];

    public static List<Drink> ReadAll() => Drinks;


    public static void Update(int id, Drink drink) => Drinks[id] = drink;


    public static void Delete(int id) => Drinks.RemoveAt(id);

    public static void Delete(Drink drink) => Drinks.Remove(drink);

    public static void DeleteAll() => Drinks.Clear();
}