namespace DesktopApplication.Model;

public class Pizza : Product
{
    public Pizza(string name, double price) : base(name, price)
    {
    }
    
    public override object Clone() => new Pizza(Name, Price);
}