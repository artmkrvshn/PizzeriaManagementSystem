using System.Collections.ObjectModel;
using System.Linq;

namespace DesktopApplication.Model;

public class Basket : BaseModel
{
    public ObservableCollection<Product> Products { get; } = new();

    private double _price;

    public double Price
    {
        get => _price;
        private set => SetField(ref _price, value);
    }

    public Basket()
    {
        Products.CollectionChanged += (sender, args) => { Price = Products.Sum(prod => prod.Price); };
    }
}