using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopApplication.Model;

public class Order : BaseModel
{
    private OrderStatus _status = OrderStatus.InProcess;

    public List<Product> Products { get; }

    public double Price { get; }

    public new string ToString => string.Join(", ", Products);

    public OrderStatus Status
    {
        get => _status;
        set => SetField(ref _status, value);
    }

    public Order(Basket basket)
    {
        Products = basket.Products.ToList();
        Price = basket.Price;
    }
}