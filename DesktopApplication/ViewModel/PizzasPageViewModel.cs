using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DesktopApplication.Model;
using DesktopApplication.Repository;

namespace DesktopApplication.ViewModel;

public class PizzasPageViewModel : ViewModelBase
{
    private ObservableCollection<PizzaCard> _pizzaCards = new(PizzaCardRepository.ReadAll());

    #region Properties

    public ObservableCollection<PizzaCard> PizzaCards
    {
        get => _pizzaCards;
        set => SetProperty(ref _pizzaCards, value);
    }

    #endregion

    
    // public ObservableCollection<PizzaCard> PizzaCards { get; } = new(PizzaCardRepository.ReadAll());
    //
    // public ObservableCollection<Crust> Crusts { get; } = new(CrustRepository.ReadAll());

}