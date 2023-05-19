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
using DesktopApplication.Model;
using DesktopApplication.ViewModel;

namespace DesktopApplication.View
{
    /// <summary>
    /// Interaction logic for PizzasPage.xaml
    /// </summary>
    public partial class PizzasPage : Page
    {
        public PizzasPage()
        {
            InitializeComponent();
        }

        private void AddProductToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            Card example = (Card)((Button)sender).DataContext;
            Pizza pizza = (Pizza)example.Product.Clone();
            MainWindowViewModel.Basket.Products.Add(pizza);
        }
    }
}