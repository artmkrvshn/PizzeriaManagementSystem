using System;
using System.Collections.Generic;
using System.Linq;
using DesktopApplication.Model;
using static DesktopApplication.Model.Ingredient;

namespace DesktopApplication.Repository;

public static class IngredientRepository
{
    private static List<Ingredient> Ingredients { get; set; } = new()
    {
        new Ingredient("Chicken", IngredientType.Extra),
        new Ingredient("Smoked Bacon", IngredientType.Extra),
        new Ingredient("Ham", IngredientType.Extra),
        new Ingredient("Jalapeños", IngredientType.Extra),
        new Ingredient("Spicy Pork", IngredientType.Extra),
        new Ingredient("Sweetcorn", IngredientType.Extra),
        new Ingredient("Tomato", IngredientType.Extra),

        new Ingredient("Triple Cheese Blend", IngredientType.Extra),

        new Ingredient("Mozzarella Cheese", IngredientType.Cheese),
        new Ingredient("Extra Mozzarella Cheese", IngredientType.Cheese),

        new Ingredient("Red Onions", IngredientType.Extra),
        new Ingredient("Mixed Peppers", IngredientType.Extra),
        new Ingredient("Seasoned Minced Beef", IngredientType.Extra),
        new Ingredient("Mushrooms", IngredientType.Extra),
        new Ingredient("Pepperoni", IngredientType.Extra),
        new Ingredient("Pineapple", IngredientType.Extra),
        new Ingredient("Green Chillies", IngredientType.Extra),

        new Ingredient("Tomato Sauce", IngredientType.Sauce),
        new Ingredient("BBQ Sauce", IngredientType.Sauce)
    };

    public static void Create(Ingredient ingredient) => Ingredients.Add(ingredient);

    public static void CreateAll(List<Ingredient> ingredients) => Ingredients.AddRange(ingredients);


    public static Ingredient Read(int id) => Ingredients[id];

    public static Ingredient Read(string name)
    {
        if (!Ingredients.Exists(i => i.Name.Equals(name)))
            throw new Exception("Ingredient with this name doesn't exist.");
        return Ingredients.First(ing => ing.Name.Equals(name));
    }

    public static List<Ingredient> Read(string[] names)
    {
        return names.Select(Read).ToList();
    }

    public static List<Ingredient> ReadAllByType(IngredientType type) => Ingredients.FindAll(i => i.Type.Equals(type));

    public static List<Ingredient> ReadAll() => new(Ingredients);


    public static void Update(int id, Ingredient ingredient) => Ingredients[id] = ingredient;


    public static void Delete(int id) => Ingredients.RemoveAt(id);

    public static void Delete(string name) => Ingredients.RemoveAll(i => i.Name.Equals(name));

    public static void Delete(Ingredient ingredient) => Ingredients.Remove(ingredient);

    public static void DeleteAll() => Ingredients.Clear();
}