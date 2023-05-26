using DesktopApplication.Model;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class OrderRepository
{
    private static List<Order> Orders { get; } = new();

    public static void Create(Order order) => Orders.Add(order);

    public static void CreateAll(IEnumerable<Order> orders) => Orders.AddRange(orders);

    public static Order Read(int id) => Orders[id];

    public static List<Order> ReadAll() => Orders;


    public static void Update(int id, Order order) => Orders[id] = order;


    public static void Delete(int id) => Orders.RemoveAt(id);

    public static void Delete(Order order) => Orders.Remove(order);

    public static void DeleteAll() => Orders.Clear();
}