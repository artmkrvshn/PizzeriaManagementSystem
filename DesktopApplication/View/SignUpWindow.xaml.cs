using DesktopApplication.ViewModel;
using System.Windows;

namespace DesktopApplication.View
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
            SignUpWindowViewModel.CloseAction = Close;
        }
    }
}