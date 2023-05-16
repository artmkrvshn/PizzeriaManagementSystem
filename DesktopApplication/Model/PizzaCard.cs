using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model;

public class PizzaCard : Card<Pizza>
{
    public PizzaCard(Pizza product, string description, string image) : base(product, description, image)
    {
    }
}