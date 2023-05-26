using DesktopApplication.Model;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class PizzaCardRepository
{
    private static List<Card> PizzaCards { get; } = new()
    {
        new Card(PizzaRepository.Read(0),
            "Double Pepperoni, Extra Mozzarella Cheese",
            "pepperoni-feast.jpg"),
        new Card(PizzaRepository.Read(1),
            "Now With Even More Pepperoni, Mozzarella And Triple Cheese Blend",
            "loaded-pepperoni-feast.jpg"),
        new Card(PizzaRepository.Read(2),
            "Mozzarella Cheese, Tomato Sauce",
            "margherita.jpg"),
        new Card(PizzaRepository.Read(3),
            "Now With Even More Mozzarella, Tomato Sauce And Triple Cheese Blend",
            "loaded-margherita.jpg"),
        new Card(PizzaRepository.Read(4),
            "Now With Even More Chicken, Mushrooms, Mixed Peppers, Red Onions And Triple Cheese Blend",
            "loaded-chicken-supreme.jpg"),
        new Card(PizzaRepository.Read(5),
            "Ham, Pineapple",
            "hawaiian.jpg"),
        new Card(PizzaRepository.Read(6),
            "Now With Even More Ham, Pineapple And Triple Cheese Blend",
            "loaded-hawaiian.jpg"),
        new Card(PizzaRepository.Read(7),
            "Spicy Pork, Ham, Pepperoni, Seasoned Minced Beef",
            "meat-feast.jpg"),
        new Card(PizzaRepository.Read(8),
            "Pepperoni, Spicy Pork, Seasoned Minced Beef, Smoked Bacon, Chicken",
            "meaty-one.jpg"),
        new Card(PizzaRepository.Read(9),
            "Ham, Mushrooms",
            "farmhouse.jpg"),
        new Card(PizzaRepository.Read(10),
            "BBQ Sauce, Smoked Bacon, Chicken",
            "texan-bbq.jpg"),
        new Card(PizzaRepository.Read(11),
            "BBQ Sauce, Spicy Pork, Ham, Pepperoni, Seasoned Minced Beef",
            "bbq-meatfeast.jpg"),
        new Card(PizzaRepository.Read(12),
            "Green Chillies, Jalapeños, Mixed Peppers, Roquito Peppers, Red Onions",
            "veg-sizzler.jpg")
    };

    public static void Create(Card pizzaCard) => PizzaCards.Add(pizzaCard);

    public static void CreateAll(IEnumerable<Card> pizzaCards) => PizzaCards.AddRange(pizzaCards);

    public static Card Read(int id) => PizzaCards[id];

    public static List<Card> ReadAll() => PizzaCards;


    public static void Update(int id, Card pizzaCard) => PizzaCards[id] = pizzaCard;


    public static void Delete(int id) => PizzaCards.RemoveAt(id);

    public static void Delete(Card pizzaCard) => PizzaCards.Remove(pizzaCard);

    public static void DeleteAll() => PizzaCards.Clear();
}