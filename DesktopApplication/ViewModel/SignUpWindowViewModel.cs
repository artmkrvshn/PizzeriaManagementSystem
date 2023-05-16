using DesktopApplication.Repository;
using System.Windows.Input;
using System.Windows;
using System;

namespace DesktopApplication.ViewModel;

class SignUpWindowViewModel : ViewModelBase
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

    #region RepeatPassword

    private string _repeatPassword = "Repeat password";

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