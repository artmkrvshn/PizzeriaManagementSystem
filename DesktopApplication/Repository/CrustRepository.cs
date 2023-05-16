using System.Collections.Generic;
using System.Collections.ObjectModel;
using DesktopApplication.Model;

namespace DesktopApplication.Repository;

public static class CrustRepository
{
    public static ObservableCollection<Crust> Crusts { get; set; } = new()
    {
        new Crust("Large Classic", 17.49, 1.80),
        new Crust("Large Classic no Garlic", 17.49, 1.80),
        new Crust("Large Stuffed", 20.48, 1.80),
        new Crust("Large Pan", 17.49, 1.80),

        new Crust("Medium Classic", 15.49, 1.60),
        new Crust("Medium Classic no Garlic", 15.49, 1.60),
        new Crust("Medium Gluten-Free", 15.49, 1.60),

        new Crust("Small Classic", 13.49, 1.40),
        new Crust("Small Classic no Garlic", 13.49, 1.40)
    };

    public static void Create(Crust crust) => Crusts.Add(crust);

    public static void CreateAll(List<Crust> crusts)
    {
        foreach (var crust in crusts)
        {
            Crusts.Add(crust);
        }
        // Crusts.AddRange(crusts);
    }


    public static Crust Read(int id) => Crusts[id];

    public static ObservableCollection<Crust> ReadAll() => Crusts;

    
    public static void Update(int id, Crust crust) => Crusts[id] = crust;


    public static void Delete(int id) => Crusts.RemoveAt(id);

    // public static void Delete(string name)
    // {
    //     foreach (var crust in Crusts)
    //     {
    //         if (crust.Name.Equals(name))
    //         {
    //             Crusts.Remove(crust);
    //         }
    //     }
    //     // Crusts.RemoveAll(i => i.Name.Equals(name));
    // }

    public static void Delete(Crust crust) => Crusts.Remove(crust);

    public static void DeleteAll() => Crusts.Clear();
}