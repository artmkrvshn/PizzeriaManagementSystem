namespace DesktopApplication.Model;

public class Drink : Product
{
    private int _volume;

    public int Volume
    {
        get => _volume;
        set
        {
            if (value <= 0) return;
            SetField(ref _volume, value);
        }
    }

    public Drink(string name, double price, int volume) : base(name, price)
    {
        _volume = volume;
    }

    public override object Clone() => new Drink(Name, Price, Volume);
}