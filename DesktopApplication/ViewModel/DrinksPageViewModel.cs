using DesktopApplication.Model;
using DesktopApplication.Repository;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace DesktopApplication.ViewModel;

public class DrinksPageViewModel
{
    public static ItemsControl? DrinksItemsControl { get; set; }

    public static ObservableCollection<Card> DrinkCards => new(DrinkCardRepository.ReadAll());
}