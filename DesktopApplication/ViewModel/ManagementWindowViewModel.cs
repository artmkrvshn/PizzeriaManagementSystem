using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApplication.Model;
using DesktopApplication.Repository;

namespace DesktopApplication.ViewModel;

class ManagementWindowViewModel : ViewModelBase
{
    private ObservableCollection<Pizza> _pizzas = PizzaRepository.Pizzas;

    public ObservableCollection<Pizza> Pizzas
    {
        get => _pizzas;
        set => SetProperty(ref _pizzas, value);
    }

    private ObservableCollection<Crust> _crusts = CrustRepository.Crusts;

    public ObservableCollection<Crust> Crusts
    {
        get => _crusts;
        set { SetProperty(ref _crusts, value); OnPropertyChanged(nameof(Pizzas)); }
    }

    private void ComboBoxTest_OnSelectionChanged()
    {
        throw new NotImplementedException();
    }
}