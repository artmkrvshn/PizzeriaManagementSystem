using System.Collections.Generic;
using System.Collections.ObjectModel;
using DesktopApplication.Model;
using DesktopApplication.Repository;

namespace DesktopApplication.ViewModel;

public class PizzasPageViewModel : ViewModelBase
{
    private ObservableCollection<PizzaCard> _pizzaCards = PizzaCardRepository.ReadAll();

    public ObservableCollection<PizzaCard> PizzaCards
    {
        get => _pizzaCards;
        set => SetProperty(ref _pizzaCards, value);
    }

    private ObservableCollection<Crust> _crustsTypeValues = CrustRepository.Crusts;


    public ObservableCollection<Crust> CrustTypeValues
    {
        get => _crustsTypeValues;
        set => SetProperty(ref _crustsTypeValues, value);
    }
}