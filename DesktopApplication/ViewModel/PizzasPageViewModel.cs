using DesktopApplication.Model;
using DesktopApplication.Repository;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace DesktopApplication.ViewModel;

public class PizzasPageViewModel : ViewModelBase
{
    public static ItemsControl? PizzasItemsControl { get; set; }

    public static ObservableCollection<Card> PizzaCards => new(PizzaCardRepository.ReadAll());
}