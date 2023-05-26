using DesktopApplication.Model;

namespace PizzeriaTest;

[TestClass]
public class PizzaTest
{
    [TestMethod]
    public void Name_Getter_ReturnsCorrectValue()
    {
        // Arrange
        string expectedName = "Margherita";
        double price = 9.99;
        Pizza pizza = new(expectedName, price);

        // Act
        string actualName = pizza.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Name_Setter_SetsCorrectValue()
    {
        // Arrange
        string initialName = "Margherita";
        double price = 9.99;
        Pizza pizza = new(initialName, price);

        string expectedName = "Pepperoni";

        // Act
        pizza.Name = expectedName;
        string actualName = pizza.Name;

        // Assert
        Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Name_Setter_NotSetIncorrectValue()
    {
        // Arrange
        string initialName = "Margherita";
        double price = 9.99;
        Pizza pizza = new(initialName, price);

        string newName = "";

        // Act
        pizza.Name = newName;
        string actualName = pizza.Name;

        // Assert
        Assert.AreEqual(initialName, actualName);
    }

    [TestMethod]
    public void Price_Getter_ReturnsCorrectValue()
    {
        // Arrange
        string name = "Margherita";
        double expectedPrice = 9.99;
        Pizza pizza = new(name, expectedPrice);

        // Act
        double actualPrice = pizza.Price;

        // Assert
        Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void Price_Setter_SetsCorrectValue()
    {
        // Arrange
        string name = "Margherita";
        double initialPrice = 9.99;
        Pizza pizza = new(name, initialPrice);

        double expectedPrice = 12.99;

        // Act
        pizza.Price = expectedPrice;
        double actualPrice = pizza.Price;

        // Assert
        Assert.AreEqual(expectedPrice, actualPrice);
    }

    
    [TestMethod]
    public void Price_Setter_NotSetIncorrectValue()
    {
        string name = "Margherita";
        double initialPrice = 9.99;
        Pizza pizza = new(name, initialPrice);

        double newPrice = -1;

        // Act
        pizza.Price = newPrice;
        double actualPrice = pizza.Price;

        // Assert
        Assert.AreEqual(initialPrice, actualPrice);
    }

    [TestMethod]
    public void Clone_ReturnsNewInstanceWithSameNameAndPrice()
    {
        // Arrange
        Pizza originalPizza = new("Margherita", 9.99);

        // Act
        Pizza clonedPizza = (Pizza)originalPizza.Clone();

        // Assert
        Assert.AreNotSame(originalPizza, clonedPizza);
        Assert.AreEqual(originalPizza.Name, clonedPizza.Name);
        Assert.AreEqual(originalPizza.Price, clonedPizza.Price);
    }

    [TestMethod]
    public void Clone_ModifyingCloneDoesNotAffectOriginal()
    {
        // Arrange
        Pizza originalPizza = new("Margherita", 9.99);
        Pizza clonedPizza = (Pizza)originalPizza.Clone();

        // Act
        clonedPizza.Name = "Pepperoni";
        clonedPizza.Price = 12.99;

        // Assert
        Assert.AreNotEqual(originalPizza.Name, clonedPizza.Name);
        Assert.AreNotEqual(originalPizza.Price, clonedPizza.Price);
    }
}