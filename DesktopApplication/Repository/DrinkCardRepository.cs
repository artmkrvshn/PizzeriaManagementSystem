using DesktopApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Repository;

public class DrinkCardRepository
{
    private static List<DrinkCard> DrinkCards { get; } = new()
    {
        new DrinkCard(DrinkRepository.Read(0), "1.5L Bottle", "pepsi-max-1500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(1), "500ml Bottle", "pepsi-max-500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(2), "1.5L Bottle", "pepsi-max-cherry-1500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(3), "1.5L Bottle", "pepsi-diet-1500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(4), "500ml Bottle", "pepsi-diet-500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(5), "1.5L Bottle", "7up-1500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(6), "500ml Bottle", "7up-500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(7), "1.5L Bottle", "pepsi-regular-1500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(8), "500ml Bottle", "pepsi-regular-500ml.jpg"),
        new DrinkCard(DrinkRepository.Read(9), "500ml Bottle", "water-500ml.jpg")
    };

    public static List<DrinkCard> ReadAll() => DrinkCards;
}