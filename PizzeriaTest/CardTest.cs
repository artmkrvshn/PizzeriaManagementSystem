using DesktopApplication.Model;

namespace PizzeriaTest;

[TestClass]
public class CardTest
{
    [TestMethod]
    public void Description_Getter_ReturnsCorrectValue()
    {
        // Arrange
        Product? product = null;
        string expectedDescription = "Double Pepperoni, Extra Mozzarella Cheese";
        Card card = new(product!, expectedDescription);

        // Act
        string actualDescription = card.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }

    [TestMethod]
    public void Description_Setter_SetsCorrectValue()
    {
        // Arrange
        Product? product = null;
        string initialDescription = "Double Pepperoni, Extra Mozzarella Cheese";
        Card card = new(product!, initialDescription);

        string expectedDescription = "New Description";

        // Act
        card.Description = expectedDescription;
        string actualDescription = card.Description;

        // Assert
        Assert.AreEqual(expectedDescription, actualDescription);
    }

    [TestMethod]
    public void Description_Setter_NotSetIncorrectValue()
    {
        // Arrange
        Product? product = null;
        string initialDescription = "Double Pepperoni, Extra Mozzarella Cheese";
        Card card = new(product!, initialDescription);

        string newDescription = "";

        // Act
        card.Description = newDescription;
        string actualDescription = card.Description;

        // Assert
        Assert.AreEqual(initialDescription, actualDescription);
    }
}