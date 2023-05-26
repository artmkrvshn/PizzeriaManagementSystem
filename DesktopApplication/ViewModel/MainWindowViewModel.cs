using DesktopApplication.Model;
using DesktopApplication.Repository;
using DesktopApplication.View;
using System.Windows.Input;

namespace DesktopApplication.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    public static User? User { get; set; } = UserRepository.Read(0);

    public static Basket Basket { get; } = new();

    public ICommand ShowSignInWindowCommand { get; }

    public ICommand ShowSignUpWindowCommand { get; }

    public ICommand ShowManagementWindowCommand { get; }

    public ICommand SignOutCommand { get; }

    public ICommand ShowProfileCommand { get; }

    public ICommand CheckoutCommand { get; }

    public MainWindowViewModel()
    {
        ShowSignInWindowCommand = new RelayCommand(_ => User == null, _ => ShowSignInWindow());
        ShowSignUpWindowCommand = new RelayCommand(_ => User == null, _ => ShowSignUpWindow());
        ShowManagementWindowCommand = new RelayCommand(_ => IsAdmin(), _ => ShowManagementWindow());
        SignOutCommand = new RelayCommand(_ => User != null, _ => SignOut());
        ShowProfileCommand = new RelayCommand(_ => User != null, _ => ShowProfileWindow());
        CheckoutCommand = new RelayCommand(_ => Basket.Products.Count > 0, _ => Checkout());
    }

    private static void ShowSignInWindow() => new SignInWindow().ShowDialog();

    private static void ShowSignUpWindow() => new SignUpWindow().ShowDialog();

    private static bool IsAdmin() => User is { UserRole: UserRole.Administrator };

    private static void ShowManagementWindow() => new ManagementWindow().ShowDialog();

    private static void Checkout()
    {
        OrderRepository.Create(new Order(Basket));
        Basket.Products.Clear();
    }

    private static void SignOut() => User = null;

    private static void ShowProfileWindow() => new ManagementWindow().ShowDialog();
}