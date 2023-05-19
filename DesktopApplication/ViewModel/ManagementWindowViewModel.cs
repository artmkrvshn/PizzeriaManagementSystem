using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DesktopApplication.Model;
using DesktopApplication.Repository;
using DesktopApplication.View;

namespace DesktopApplication.ViewModel;

class ManagementWindowViewModel : ViewModelBase
{
    // private ObservableCollection<Pizza> _pizzas = new(PizzaRepository.ReadAll());
    //
    // public ObservableCollection<Pizza> Pizzas
    // {
    //     get => _pizzas;
    //     set => SetProperty(ref _pizzas, value);
    // }
    //
    // private ObservableCollection<Crust> _crusts = new(CrustRepository.ReadAll());
    //
    // public ObservableCollection<Crust> Crusts
    // {
    //     get => _crusts;
    //     set
    //     {
    //         SetProperty(ref _crusts, value);
    //         OnPropertyChanged(nameof(Pizzas));
    //     }
    // }
    //
    // private void ComboBoxTest_OnSelectionChanged()
    // {
    //     throw new NotImplementedException();
    // }

    public ObservableCollection<Pizza> Pizzas { get; set; } = new(PizzaRepository.ReadAll());

    // public ObservableCollection<Crust> Crusts { get; set; } = new(CrustRepository.ReadAll());

    public ObservableCollection<PizzaCard> PizzaCards { get; set; } = new(PizzaCardRepository.ReadAll());

    public ObservableCollection<User> Users { get; set; } = new(UserRepository.ReadAll());


    // public ICommand SaveCommand { get; }
    // public ICommand ShowDBCommand { get; }
    // public ICommand ShowVMCommand { get; }

    public ManagementWindowViewModel()
    {
        // SaveCommand = new RelayCommand(p => true, p => Save());
        // ShowDBCommand = new RelayCommand(p => true, p => ShowCrusts("DB", CrustRepository.ReadAll()));
        // ShowVMCommand = new RelayCommand(p => true, p => ShowCrusts("VM", Crusts.ToList()));
    }
}