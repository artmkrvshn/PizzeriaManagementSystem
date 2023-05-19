using DesktopApplication.Model;
using DesktopApplication.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DesktopApplication.ViewModel;

class RepositoryViewModel : ViewModelBase
{
    private ObservableCollection<Pizza> _pizzas = new(PizzaRepository.ReadAll());
    private ObservableCollection<Crust> _crusts = new(CrustRepository.ReadAll());
    private ObservableCollection<PizzaCard> _pizzaCards = new(PizzaCardRepository.ReadAll());

    #region Properties

    public ObservableCollection<Pizza> Pizzas
    {
        get => _pizzas;
        set => SetProperty(ref _pizzas, value);
    }


    public ObservableCollection<Crust> Crusts
    {
        get => _crusts;
        set
        {
            SetProperty(ref _crusts, value);
            OnPropertyChanged(nameof(Pizzas));
            // OnPropertyChanged(nameof(PizzaCards));
        }
    }

    public ObservableCollection<PizzaCard> PizzaCards
    {
        get => _pizzaCards;
        set => SetProperty(ref _pizzaCards, value);
    }

    #endregion
}