using System.Windows;
using System.Windows.Input;
using DesktopApplication.Model;
using DesktopApplication.View;

namespace DesktopApplication.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    public static User? User { get; set; } = null;

    public static Basket Basket { get; set; } = new();

    public ICommand ShowSignInWindowCommand { get; }

    public ICommand ShowSignUpWindowCommand { get; }

    public ICommand ShowManagementWindowCommand { get; }

    public MainWindowViewModel()
    {
        ShowSignInWindowCommand = new RelayCommand(p => User == null, p => ShowSignInWindow());
        ShowSignUpWindowCommand = new RelayCommand(p => User == null, p => ShowSignUpWindow());
        ShowManagementWindowCommand = new RelayCommand(p => User is { UserRole: UserRole.Administrator },
            p => ShowManagementWindow());
    }

    private void ShowSignInWindow() => new SignInWindow().ShowDialog();

    private void ShowSignUpWindow() => new SignUpWindow().ShowDialog();

    private void ShowManagementWindow() => new ManagementWindow().ShowDialog();




    /*
    public ObservableCollection<User> Users { get; set; } = new(UserRepository.ReadAll());

    private string _email;

    private string _password;

    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    private ICommand _logInCommand;

    public ICommand LogInCommand
    {
        get
        {
            if (_logInCommand == null)
            {
                _logInCommand = new RelayCommand(
                    p => this.CanLogin(),
                    p => this.LogIn());
            }

            return _logInCommand;
        }
    }

    private void LogIn()
    {
        MessageBox.Show($"Logged In as {UserRepository.Read(Email, Password)}");
    }

    private bool CanLogin()
    {
        return true;
    }
    */
}