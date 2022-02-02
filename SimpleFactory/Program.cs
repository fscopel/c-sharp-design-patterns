//Make pizzas

using SimpleFactory;
using SimpleFactory.Pizza;
using SimpleFactory.Store;
using Xunit;

var pepperoni = SimplePizzaFactory.CreatePizza(PizzaType.Pepperoni);
var chickenPizza = SimplePizzaFactory.CreatePizza(PizzaType.Chicken);

Console.WriteLine(pepperoni.Name);
Console.WriteLine(chickenPizza.Name);

var pizza = new NewYorkPizzaStore().OrderPizza(new List<string>());

Console.WriteLine($"Pizza is New York Style: {pizza.GetType().Name}");

Console.ReadLine();
