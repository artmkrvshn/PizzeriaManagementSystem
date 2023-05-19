using System;
using System.Collections.Generic;
using System.Linq;
using DesktopApplication.Model;

namespace DesktopApplication.Repository;

public static class CrustRepository
{
    private static List<Crust> Crusts { get; } = new()
    {
        new Crust("Large Classic", 1.1),
        new Crust("Large Classic no Garlic", 1.1),
        new Crust("Large Stuffed", 1.2),
        new Crust("Large Pan", 1.1),

        new Crust("Medium Classic", 1.0),
        new Crust("Medium Classic no Garlic", 1.0),
        new Crust("Medium Gluten-Free", 1.0),

        new Crust("Small Classic", 0.9),
        new Crust("Small Classic no Garlic", 0.9)
    };

    public static void Create(Crust crust) => Crusts.Add(crust);

    public static void CreateAll(List<Crust> crusts) => Crusts.AddRange(crusts);

    public static void ClearAndCreateAll(List<Crust> crusts)
    {
        // Crusts.Clear();
        // CreateAll(crusts);
    }

    public static Crust Read(int id) => Crusts[id];

    public static Crust Read(string name)
    {
        return Crusts.Find(crust => crust.Name.Equals(name)) ?? throw new Exception("Crust with this name doesn't exist");
    }

    public static List<Crust> ReadAll()
    {
        // return Crusts.Select(crust => (Crust)crust.Clone()).ToList();
        return Crusts;
    }


    public static void Update(int id, Crust crust) => Crusts[id] = crust;


    public static void Delete(int id) => Crusts.RemoveAt(id);

    public static void Delete(Crust crust) => Crusts.Remove(crust);

    public static void DeleteAll() => Crusts.Clear();
}