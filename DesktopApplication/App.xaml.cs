using DesktopApplication.Model;
using DesktopApplication.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace DesktopApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void AddProductToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            Card example = (Card)((Button)sender).DataContext;
            Product product = (Product)example.Product.Clone();
            MainWindowViewModel.Basket.Products.Add(product);
        }
    }
}
