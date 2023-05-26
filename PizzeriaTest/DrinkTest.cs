using DesktopApplication.Model;

namespace PizzeriaTest;

[TestClass]
public class DrinkTest
{
    [TestMethod]
    public void Name_Getter_ReturnsCorrectValue()
    {
        // Arrange
        string expectedName = "Water";
        double price = 1.29;
        int volume = 250;
        Drink drink = new(expectedName, price, volume);

        // Act
        string actualName = drink.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Name_Setter_SetsCorrectValue()
    {
        // Arrange
        string initialName = "Water";
        double price = 1.29;
        int volume = 250;
        Drink drink = new(initialName, price, volume);

        string expectedName = "Cola";

        // Act
        drink.Name = expectedName;
        string actualName = drink.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Name_Setter_NotSetIncorrectValue()
    {
        // Arrange
        string initialName = "Water";
        double price = 1.29;
        int volume = 250;
        Drink drink = new(initialName, price, volume);

        string newName = "";

        // Act
        drink.Name = newName;
        string actualName = drink.Name;

        // Assert
        Assert.AreEqual(initialName, actualName);
    }

    [TestMethod]
    public void Price_Getter_ReturnsCorrectValue()
    {
        // Arrange
        string name = "Water";
        double expectedPrice = 1.29;
        int volume = 250;
        Drink drink = new(name, expectedPrice, volume);

        // Act
        double actualPrice = drink.Price;

        // Assert
        Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void Price_Setter_SetsCorrectValue()
    {
        // Arrange
        string name = "Water";
        double initialPrice = 1.29;
        int volume = 250;
        Drink drink = new(name, initialPrice, volume);

        double expectedPrice = 2.29;

        // Act
        drink.Price = expectedPrice;
        double actualPrice = drink.Price;

        // Assert
        Assert.AreEqual(expectedPrice, actualPrice);
    }


    [TestMethod]
    public void Price_Setter_NotSetIncorrectValue()
    {
        // Arrange
        string name = "Water";
        double initialPrice = 1.29;
        int volume = 250;
        Drink drink = new(name, initialPrice, volume);

        double newPrice = -1;

        // Act
        drink.Price = newPrice;
        double actualPrice = drink.Price;

        // Assert
        Assert.AreEqual(initialPrice, actualPrice);
    }

    
    [TestMethod]
    public void Volume_Getter_ReturnsCorrectValue()
    {
        // Arrange
        string name = "Water";
        double price = 1.29;
        int expectedVolume = 250;
        Drink drink = new(name, price, expectedVolume);

        // Act
        double actualVolume = drink.Volume;

        // Assert
        Assert.AreEqual(expectedVolume, actualVolume);
    }

    [TestMethod]
    public void Volume_Setter_SetsCorrectValue()
    {
        // Arrange
        string name = "Water";
        double price = 1.29;
        int initialVolume = 250;
        Drink drink = new(name, price, initialVolume);

        int expectedVolume = 1000;

        // Act
        drink.Volume = expectedVolume;
        int actualVolume = drink.Volume;

        // Assert
        Assert.AreEqual(expectedVolume, actualVolume);
    }


    [TestMethod]
    public void Volume_Setter_NotSetIncorrectValue()
    {
        // Arrange
        string name = "Water";
        double price = 1.29;
        int initialVolume = 250;
        Drink drink = new(name, price, initialVolume);

        int newVolume = 0;

        // Act
        drink.Volume = newVolume;
        int actualVolume = drink.Volume;

        // Assert
        Assert.AreEqual(initialVolume, actualVolume);
    }

    [TestMethod]
    public void Clone_ReturnsNewInstanceWithSameNameAndPrice()
    {
        // Arrange
        Drink originalDrink = new("Water", 1.99, 250);

        // Act
        Drink clonedDrink = (Drink)originalDrink.Clone();

        // Assert
        Assert.AreNotSame(originalDrink, clonedDrink);
        Assert.AreEqual(originalDrink.Name, clonedDrink.Name);
        Assert.AreEqual(originalDrink.Price, clonedDrink.Price);
        Assert.AreEqual(originalDrink.Volume, clonedDrink.Volume);
    }

    [TestMethod]
    public void Clone_ModifyingCloneDoesNotAffectOriginal()
    {
        // Arrange
        Drink originalDrink = new("Water", 1.99, 250);
        Drink clonedDrink = (Drink)originalDrink.Clone();

        // Act
        clonedDrink.Name = "Cola";
        clonedDrink.Price = 2.99;
        clonedDrink.Volume = 1000;

        // Assert
        Assert.AreNotEqual(originalDrink.Name, clonedDrink.Name);
        Assert.AreNotEqual(originalDrink.Price, clonedDrink.Price);
        Assert.AreNotEqual(originalDrink.Volume, clonedDrink.Volume);
    }
}