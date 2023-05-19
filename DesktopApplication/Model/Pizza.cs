using System;

namespace DesktopApplication.Model;

public class Pizza : Product
{
    public Pizza(string name, double price) : base(name, price)
    {
    }

    public override bool Equals(object? obj)
    {
        return obj is Pizza pizza &&
               Id.Equals(pizza.Id) &&
               Name.Equals(pizza.Name) &&
               Price.Equals(pizza.Price);
    }

    public override int GetHashCode() => HashCode.Combine(Id, Name, Price);

    public override string ToString() => $"Pizza(Name={Name}, Price={Price})";

    public override object Clone() => new Pizza(Name, Price);
}