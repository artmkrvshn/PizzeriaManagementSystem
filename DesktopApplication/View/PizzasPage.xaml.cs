using System.Windows.Controls;
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
            PizzasPageViewModel.PizzasItemsControl = PizzasItemsControl;
        }
    }
}