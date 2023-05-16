using System;
using System.Windows;
using System.Windows.Input;
using DesktopApplication.Repository;

namespace DesktopApplication.ViewModel;

public class SignInWindowViewModel : ViewModelBase
{
    #region Email

    private string _email = "Email";

    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    #endregion

    #region Password

    private string _password = "Password";

    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    #endregion

    public static Action? CloseAction { get; set; }

    public ICommand SignInCommand { get; }

    public SignInWindowViewModel()
    {
        SignInCommand = new RelayCommand(p => true, p => SignIn());
    }

    private void SignIn()
    {
        if (UserRepository.Exists(Email, Password))
        {
            MainWindowViewModel.User = UserRepository.Read(Email, Password);
            CloseAction?.Invoke();
        }
        else
        {
            MessageBox.Show("Wrong email or password");
        }
    }
}