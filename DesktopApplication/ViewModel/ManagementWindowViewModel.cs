using DesktopApplication.Model;
using DesktopApplication.Repository;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DesktopApplication.ViewModel;

class ManagementWindowViewModel : ViewModelBase
{
    private string _name = "Name";

    private double _price = 0.99;

    private string _description = "Description";

    private int _volume = 250;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value)) return;
            SetProperty(ref _name, value);
        }
    }

    public double Price
    {
        get => _price;
        set
        {
            if (value <= 0) return;
            SetProperty(ref _price, value);
        }
    }

    public int Volume
    {
        get => _volume;
        set
        {
            if (value <= 0) return;
            SetProperty(ref _volume, value);
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            if (string.IsNullOrEmpty(value)) return;
            SetProperty(ref _description, value);
        }
    }

    public ObservableCollection<Card> PizzaCards { get; } = new(PizzaCardRepository.ReadAll());

    public ObservableCollection<Card> DrinkCards { get; } = new(DrinkCardRepository.ReadAll());

    public ObservableCollection<User> Users { get; } = new(UserRepository.ReadAll());

    public ObservableCollection<Order> Orders { get; } = new(OrderRepository.ReadAll());

    public ICommand AddPizzaCommand { get; }

    public ICommand AddDrinkCommand { get; }

    public ManagementWindowViewModel()
    {
        AddPizzaCommand = new RelayCommand(_ => FieldsNotEmpty(), _ => AddPizza());
        AddDrinkCommand = new RelayCommand(_ => FieldsNotEmpty(), _ => AddDrink());
    }

    private bool FieldsNotEmpty() => !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description);

    private void AddPizza()
    {
        Pizza pizza = new(Name, Price);
        Card card = new(pizza, Description, "pepperoni-feast.jpg");
        PizzaRepository.Create(pizza);
        PizzaCardRepository.Create(card);
        PizzaCards.Add(card);
    }
    
    private void AddDrink()
    {
        Drink drink = new(Name, Price, Volume);
        Card card = new(drink, Description, "water-500ml.jpg");
        DrinkRepository.Create(drink);
        DrinkCardRepository.Create(card);
        DrinkCards.Add(card);
    }
}