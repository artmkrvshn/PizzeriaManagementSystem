using DesktopApplication.ViewModel;
using System.Windows;

namespace DesktopApplication.View
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
            SignInWindowViewModel.CloseAction = Close;
        }
    }
}
