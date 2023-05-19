using DesktopApplication.Model;
using DesktopApplication.ViewModel;
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

namespace DesktopApplication.View
{
    /// <summary>
    /// Interaction logic for DrinksPage.xaml
    /// </summary>
    public partial class DrinksPage : Page
    {
        public DrinksPage()
        {
            InitializeComponent();
        }
        
        private void AddProductToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            DrinkCard example = (DrinkCard)((Button)sender).DataContext;
            Drink drink= (Drink)example.Product.Clone();
            MainWindowViewModel.Basket.Products.Add(drink);
        }
    }
}
