using System.Windows.Controls;
using DesktopApplication.ViewModel;

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
            DrinksPageViewModel.DrinksItemsControl = DrinksItemsControl;
        }
    }
}
