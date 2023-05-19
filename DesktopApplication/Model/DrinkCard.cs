using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model;

public class DrinkCard : Card<Drink>
{
    public DrinkCard(Drink product, string description, string image) : base(product, description, image)
    {
    }
}