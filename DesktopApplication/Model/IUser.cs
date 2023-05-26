namespace DesktopApplication.Model;

internal interface IUser
{
    public string Email { get; set; }

    public string Password { get; set; }

    public UserRole UserRole { get; set; }
}