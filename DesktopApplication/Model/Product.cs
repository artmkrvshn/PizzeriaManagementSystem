using System;

namespace DesktopApplication.Model;

public abstract class Product : BaseModel, IProduct, ICloneable
{
    private string _name;

    private double _price;

    #region Properties

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value)) return;
            SetField(ref _name, value);
        }
    }

    public double Price
    {
        get => _price;
        set
        {
            if (value <= 0) return;
            SetField(ref _price, value);
        }
    }

    #endregion

    protected Product(string name, double price)
    {
        _name = name;
        _price = price;
    }

    public override string ToString() => Name;

    public abstract object Clone();
}