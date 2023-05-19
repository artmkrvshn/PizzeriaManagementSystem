using System;

namespace DesktopApplication.Model;

public abstract class Product : BaseModel
{
    protected Guid Id { get; } = Guid.NewGuid();

    private string _name;

    #region Properties

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    public abstract double Price { get; set; }

    public abstract string ShortDescription { get; }

    #endregion

    protected Product(string name)
    {
        _name = name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Product product &&
               Id.Equals(product.Id) &&
               Name.Equals(product.Name) &&
               Price.Equals(product.Price);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price);
    }

    public override string ToString()
    {
        return $"Product(Name={Name}, Price={Price})";
    }
}