using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopApplication.Model;

public abstract class Product : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName]string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, newValue)) return false;
        field = newValue;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }


    public Guid Id { get; }

    private string _name;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public abstract double Price { get; }

    protected Product(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
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
        return $"{Name} {Price}";
    }
}