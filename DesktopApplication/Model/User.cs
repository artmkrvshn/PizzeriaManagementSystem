using System;

namespace DesktopApplication.Model;

public class User
{
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public UserRole UserRole { get; set; }


    public User(string email, string password, UserRole userRole)
    {
        Id = new Guid();
        Email = email;
        Password = password;
        UserRole = userRole;
    }

    public override string ToString()
    {
        return $"Email={Email}, Password={Password}, Role={UserRole}";
    }
}