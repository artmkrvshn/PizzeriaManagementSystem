using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DesktopApplication.Model;
using DesktopApplication.Repository;
using DesktopApplication.ViewModel;

namespace DesktopApplication.View
{
    /// <summary>
    /// Interaction logic for ManagementWindow.xaml
    /// </summary>
    public partial class ManagementWindow : Window
    {
        public ManagementWindow()
        {
            InitializeComponent();
        }
        
        private void PizzasDataGrid_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (PizzasDataGrid.SelectedIndex < 0) return;
            Card card = (PizzasDataGrid.SelectedItem as Card)!;
            PizzasPageViewModel.PizzaCards.Remove(card);
            PizzaCardRepository.Delete(card);
        }

        private void DrinksDataGrid_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (DrinksDataGrid.SelectedIndex < 0) return;
            Card? card = (DrinksDataGrid.SelectedItem as Card)!;
            DrinksPageViewModel.DrinkCards.Remove(card);
            DrinkCardRepository.Delete(card);
        }
    }
}
