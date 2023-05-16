using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model;

public class Ingredient
{
    public string Name { get; set; }
    public IngredientType Type { get; set; }
    public bool Free { get; set; }

    public Ingredient(string name, IngredientType type)
    {
        Name = name;
        Type = type;
        Free = false;
    }

    public Ingredient(string name, IngredientType type, bool free)
    {
        Name = name;
        Type = type;
        Free = free;
    }
}
