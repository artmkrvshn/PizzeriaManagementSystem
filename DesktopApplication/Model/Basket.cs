using System.Collections.ObjectModel;
using System.Linq;

namespace DesktopApplication.Model;

public class Basket
{
    public ObservableCollection<Pizza> Products { get; set; } = new();

    public double Price { get; set; }

    public Basket()
    {
        Products.CollectionChanged += (sender, args) =>
        {
            Price = Products.Sum(prod => prod.Price);
        };
    }
}