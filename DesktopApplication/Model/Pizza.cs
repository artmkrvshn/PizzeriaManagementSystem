using System;
using DesktopApplication.Repository;

namespace DesktopApplication.Model;

public class Pizza : Product, ICloneable
{
    private Crust _crust;

    private readonly double _basePrice;

    private double _price;

    #region Properties

    public Crust Crust
    {
        get => _crust;
        set
        {
            SetField(ref _crust, value);
            Price = _basePrice * Crust.Multiplier;
        }
    }

    public override double Price
    {
        get => _price;
        set => SetField(ref _price, value);
    }

    public override string ShortDescription => Crust.Name;

    #endregion

    public Pizza(string name, double price, Crust crust) : base(name)
    {
        _basePrice = price;
        _crust = crust;
        _price = price;
        Crust = crust;
    }

    public Pizza(string name, double price) : this(name, price,
        CrustRepository.Read("Large Classic"))
    {
    }

    public override bool Equals(object? obj)
    {
        return obj is Pizza pizza &&
               Id.Equals(pizza.Id) &&
               Name.Equals(pizza.Name) &&
               Price.Equals(pizza.Price) &&
               Crust.Equals(pizza.Crust);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price, Crust);
    }

    public object Clone()
    {
        return new Pizza(Name, Price, Crust);
    }

    public override string ToString()
    {
        return $"Pizza(Name={Name}, Price={Price}, Crust={Crust})";
    }
}