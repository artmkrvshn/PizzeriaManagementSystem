using DesktopApplication.Model;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class DrinkCardRepository
{
    private static List<Card> DrinkCards { get; } = new()
    {
        new Card(DrinkRepository.Read(0), "1.5L Bottle", "pepsi-max-1500ml.jpg"),
        new Card(DrinkRepository.Read(1), "500ml Bottle", "pepsi-max-500ml.jpg"),
        new Card(DrinkRepository.Read(2), "1.5L Bottle", "pepsi-max-cherry-1500ml.jpg"),
        new Card(DrinkRepository.Read(3), "1.5L Bottle", "pepsi-diet-1500ml.jpg"),
        new Card(DrinkRepository.Read(4), "500ml Bottle", "pepsi-diet-500ml.jpg"),
        new Card(DrinkRepository.Read(5), "1.5L Bottle", "7up-1500ml.jpg"),
        new Card(DrinkRepository.Read(6), "500ml Bottle", "7up-500ml.jpg"),
        new Card(DrinkRepository.Read(7), "1.5L Bottle", "pepsi-regular-1500ml.jpg"),
        new Card(DrinkRepository.Read(8), "500ml Bottle", "pepsi-regular-500ml.jpg"),
        new Card(DrinkRepository.Read(9), "500ml Bottle", "water-500ml.jpg")
    };

    public static List<Card> ReadAll() => DrinkCards;
}