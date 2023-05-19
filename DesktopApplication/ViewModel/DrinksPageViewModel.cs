using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApplication.Model;
using DesktopApplication.Repository;

namespace DesktopApplication.ViewModel;

public class DrinksPageViewModel
{
    public ObservableCollection<Card> DrinkCards { get; } = new(DrinkCardRepository.ReadAll());
}