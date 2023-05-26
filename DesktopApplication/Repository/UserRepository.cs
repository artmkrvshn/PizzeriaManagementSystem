using DesktopApplication.Model;
using System;
using System.Collections.Generic;

namespace DesktopApplication.Repository;

public static class UserRepository
{
    private static List<User> Users { get; } = new()
    {
        new User("admin@gmail.com", "admin", UserRole.Administrator),
        new User("user@gmail.com", "user", UserRole.Customer),
    };

    public static void Create(User user) => Users.Add(user);

    public static void CreateAll(List<User> users) => Users.AddRange(users);


    public static User Read(int id) => Users[id];

    public static List<User> ReadAll() => new(Users);


    public static void Update(int id, User user) => Users[id] = user;


    public static void Delete(int id) => Users.RemoveAt(id);

    public static void Delete(User user) => Users.Remove(user);

    public static void DeleteAll() => Users.Clear();

    public static bool Exists(string email, string password)
    {
        return Users.Exists(u => u.Email.Equals(email) && u.Password.Equals(password));
    }

    public static User Read(string email, string password)
    {
        if (!Exists(email, password))
            throw new Exception("User with this email and pass doesn't exist");
        return Users.Find(u => u.Email.Equals(email) && u.Password.Equals(password))!;
    }
}
