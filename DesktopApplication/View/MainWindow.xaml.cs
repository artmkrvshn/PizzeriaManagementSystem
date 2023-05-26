using System.Collections.ObjectModel;
using DesktopApplication.Model;
using DesktopApplication.ViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DesktopApplication.Repository;

namespace DesktopApplication.View
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
        private readonly DrinksPage _drinksPage = new();

        private void PizzasPageRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PizzasPageViewModel.PizzasItemsControl!.ItemsSource = new ObservableCollection<Card>(PizzaCardRepository.ReadAll());
            ContentFrame.Navigate(_pizzasPage);
        }

        private void DrinksPageRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DrinksPageViewModel.DrinksItemsControl!.ItemsSource = new ObservableCollection<Card>(DrinkCardRepository.ReadAll());
            ContentFrame.Navigate(_drinksPage);
        }

        private void DeleteProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            Product product = (Product)((Button)sender).DataContext;
            Product toRemove = MainWindowViewModel.Basket.Products.First(prod => product.Equals(prod));
            MainWindowViewModel.Basket.Products.Remove(toRemove);
        }
    }
}
