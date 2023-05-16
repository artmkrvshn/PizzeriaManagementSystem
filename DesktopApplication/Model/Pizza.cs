using System;
using System.Collections.ObjectModel;
using System.Linq;
using DesktopApplication.Repository;
using static DesktopApplication.Model.IngredientType;

namespace DesktopApplication.Model;

public class Pizza : BaseModel, ICloneable
{
    private Guid Id { get; } = Guid.NewGuid();

    #region Name

    private string _name;

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    #endregion

    #region Price

    private double _price;


    public double Price
    {
        get => Ingredients.ToList().FindAll(i => i.Type == Extra).Count * Crust.IngredientPrice + Crust.Price;
        set => SetField(ref _price,
            Ingredients.ToList().FindAll(i => i.Type == Extra).Count * Crust.IngredientPrice + Crust.Price);
    }
    //
    // public double Price =>
    //     Ingredients.ToList().FindAll(i => i.Type == Extra).Count * Crust.IngredientPrice + Crust.Price;

    #endregion

    #region Crust

    private Crust _crust;

    public Crust Crust
    {
        get => _crust;
        set
        {
            SetField(ref _crust, value);
            // SetField(ref _price,
            //     Ingredients.ToList().FindAll(i => i.Type == Extra).Count * Crust.IngredientPrice + Crust.Price);
            OnPropertyChanged(nameof(Price));
        }
    }

    #endregion

    #region Ingredients

    private ObservableCollection<Ingredient> _ingredients;

    public ObservableCollection<Ingredient> Ingredients
    {
        get => _ingredients;
        set => SetField(ref _ingredients, value);
    }

    #endregion

    public Pizza(string name, Crust crust, ObservableCollection<Ingredient> ingredients)
    {
        _name = name;
        _crust = crust;
        _ingredients = ingredients;
    }

    public Pizza(string name, ObservableCollection<Ingredient> ingredients)
    {
        _name = name;
        _crust = CrustRepository.Read(0);
        _ingredients = ingredients;
    }

    public override bool Equals(object? obj)
    {
        return obj is Pizza pizza &&
               Id.Equals(pizza.Id) &&
               Name.Equals(pizza.Name) &&
               Price.Equals(pizza.Price) &&
               Crust.Equals(pizza.Crust) &&
               Ingredients.Equals(pizza.Ingredients);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price, Crust, Ingredients);
    }

    public object Clone()
    {
        return new Pizza(Name, Crust, Ingredients);
    }

    public override string ToString()
    {
        return $"Pizza(Name={Name}, Price={Price}, Crust={Crust}, Ingredients={Ingredients})";
    }
}