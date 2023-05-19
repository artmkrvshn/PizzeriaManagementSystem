using System;

namespace DesktopApplication.Model;

public class Crust : BaseModel, ICloneable
{
    private string _name;

    private double _multiplier;

    #region Properties

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    public double Multiplier
    {
        get => _multiplier;
        set => SetField(ref _multiplier, value);
    }
    
    #endregion
    
    public Crust(string name, double multiplier)
    {
        _name = name;
        _multiplier = multiplier;
    }

    public override bool Equals(object? obj)
    {
        return obj is Crust crust &&
               Name.Equals(crust.Name) &&
               Multiplier.Equals(crust.Multiplier);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Multiplier);
    }

    public override string ToString()
    {
        return $"Crust(Name={Name}, Multiplier={Multiplier})";
    }

    public object Clone()
    {
        return new Crust(Name, Multiplier);
    }
}