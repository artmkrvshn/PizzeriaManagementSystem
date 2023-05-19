using System.Windows;
using System.Windows.Input;
using DesktopApplication.Model;
using DesktopApplication.Repository;
using DesktopApplication.View;

namespace DesktopApplication.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    // public static User? User { get; set; } = null;
    public static User? User { get; set; } = UserRepository.Read(0);

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

    private static void ShowSignInWindow() => new SignInWindow().ShowDialog();

    private static void ShowSignUpWindow() => new SignUpWindow().ShowDialog();

    private static void ShowManagementWindow() => new ManagementWindow().ShowDialog();
}