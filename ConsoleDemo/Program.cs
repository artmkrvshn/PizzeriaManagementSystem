using DesktopApplication.Model;
using DesktopApplication.Repository;

// Console.WriteLine("Hello, World!");
//
// List<Pizza> pizzas = PizzaRepository.ReadAll();
//
// pizzas.ForEach(Console.WriteLine);


Crust c = new("NewCrust", 1.1);
Pizza p = new("Zaluponi Pizza", 18.99, c);

Console.WriteLine(p);