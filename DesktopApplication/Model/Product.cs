using System;

namespace DesktopApplication.Model;

public abstract class Product : BaseModel, ICloneable
{
    private Guid Id { get; } = Guid.NewGuid();

    private string _name;

    private double _price;

    #region Properties

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

    #endregion

    protected Product(string name, double price)
    {
        _name = name;
        _price = price;
    }

    // public override bool Equals(object? obj)
    // {
    //     return obj is Product product &&
    //            Id.Equals(product.Id) &&
    //            Name.Equals(product.Name) &&
    //            Price.Equals(product.Price);
    // }
    //
    // public override int GetHashCode()
    // {
    //     return HashCode.Combine(Id, Name, Price);
    // }
    //
    // public override string ToString()
    // {
    //     return $"Product(Name={Name}, Price={Price})";
    // }

    public abstract object Clone();
}