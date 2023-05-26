using DesktopApplication.Repository;
using System;
using System.Windows;
using System.Windows.Input;

namespace DesktopApplication.ViewModel;

class SignUpWindowViewModel : ViewModelBase
{
    private string _email = "Email";

    private string _password = "Password";

    private string _repeatPassword = "Repeat password";

    #region Properties

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
    
    public string RepeatPassword
    {
        get => _repeatPassword;
        set => SetProperty(ref _repeatPassword, value);
    }

    #endregion

    public static Action? CloseAction { get; set; }

    public ICommand SignUpCommand { get; }

    public SignUpWindowViewModel()
    {
        SignUpCommand = new RelayCommand(p => true, p => SignUp());
    }

    private void SignUp()
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