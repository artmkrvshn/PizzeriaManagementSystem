using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopApplication.Model;

public class Crust : BaseModel, ICloneable
{
    private string _name;
    private double _price;
    private double _ingredientPrice;

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    public double Price
    {
        get => _price;
        set => SetField(ref _price, value);
    }

    public double IngredientPrice
    {
        get => _ingredientPrice;
        set => SetField(ref _ingredientPrice, value);
    }

    public Crust(string name, double price, double ingredientPrice)
    {
        Name = name;
        Price = price;
        IngredientPrice = ingredientPrice;
    }

    public override bool Equals(object? obj)
    {
        return obj is Crust crust &&
               Name.Equals(crust.Name) &&
               Price.Equals(crust.Price) &&
               IngredientPrice.Equals(crust.IngredientPrice);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Price, IngredientPrice);
    }

    public override string ToString()
    {
        return $"Crust(Name={Name}, Price={Price}, IngredientPrice={IngredientPrice})";
    }

    public object Clone()
    {
        return new Crust(Name, Price, IngredientPrice);
    }
}