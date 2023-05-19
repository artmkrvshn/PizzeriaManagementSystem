using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DesktopApplication.Model;
using DesktopApplication.ViewModel;

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
