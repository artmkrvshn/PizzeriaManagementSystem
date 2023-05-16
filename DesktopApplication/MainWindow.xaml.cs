using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopApplication.View;

namespace DesktopApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly PizzasPage _pizzasPage = new();
        // private readonly DrinksPage _drinksPage = new();
        // private readonly LogInWindow _logInWindow = new();
        // private readonly SignUpWindow _signUpWindow = new();


        private void PizzasPageRadioButton_Checked(object sender, RoutedEventArgs e) => ContentFrame.Navigate(_pizzasPage);

        private void DrinksPageRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // ContentFrame.Navigate(_drinksPage);
        }
    }
}
