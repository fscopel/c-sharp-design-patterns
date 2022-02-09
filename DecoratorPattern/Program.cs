using DecoratorPattern;
using DecoratorPattern.PizzaDough;
using Newtonsoft.Json;

MeatOption meats;
VeggieOption veggies;
Crust crustTypes;
SauceTypes sauceTypes;
ToppingPrice toppings;
CheeseOption cheeses;

LoadData();

var basePizza = new BasePizza();

var crustTypeIndex = OptionsAndChoices("Choose crust type", crustTypes.CrustType);
var sizeIndex = OptionsAndChoices("Choose Size", crustTypes.CrustType[crustTypeIndex].Sizes);
var sauceIndex = OptionsAndChoices("Choose Sauce", sauceTypes.Sauces);
var sauceOptionIndex = OptionsAndChoices("Choose Sauce Option", sauceTypes.Sauces[sauceIndex].Options);
var cheeseIndex = OptionsAndChoices("Choose Cheese", cheeses.Cheese);


var crust = crustTypes.CrustType[crustTypeIndex];
var size = crustTypes.CrustType[crustTypeIndex].Sizes[sizeIndex];
var sauce = sauceTypes.Sauces[sauceIndex];
var sauceOption = sauceTypes.Sauces[sauceIndex].Options[sauceOptionIndex];
var cheese = cheeses.Cheese[cheeseIndex];

var pizza = new Ingredient(basePizza, crust.Name, crust.Price);
pizza = new Ingredient(pizza, size.Name, size.Price);
pizza = new Ingredient(pizza, sauce.Name, sauce.Price); 
pizza = new Ingredient(pizza, sauceOption.Name, sauceOption.Price);
pizza = new Ingredient(pizza, "Cheese: " + cheese.Name, cheese.Price);

//TODO: Iterate over the meats and veggies
var meatVeggieIndex = 0;
while(meatVeggieIndex != -1)
{
    meatVeggieIndex = MeatsAndVeggies("Choose meat", meats.Meats);
    if(meatVeggieIndex == -1)
        continue;

    var toppingIndex = OptionsAndChoices("Choose options", toppings.Toppings);

    pizza = new Ingredient(pizza, meats.Meats[meatVeggieIndex], 0.00m);
    pizza = new Ingredient(pizza, toppings.Toppings[toppingIndex].Name, toppings.Toppings[toppingIndex].Price);
}

meatVeggieIndex = 0;
while (meatVeggieIndex != -1)
{
    meatVeggieIndex = MeatsAndVeggies("Choose veggies", veggies.Veggies);
    if (meatVeggieIndex == -1)
        continue;

    var toppingIndex = OptionsAndChoices("Choose options", toppings.Toppings);

    pizza = new Ingredient(pizza, veggies.Veggies[meatVeggieIndex], 0.00m);
    pizza = new Ingredient(pizza, toppings.Toppings[toppingIndex].Name, toppings.Toppings[toppingIndex].Price);
}


Console.WriteLine(pizza.ToString());
Console.ReadLine();

#region Supporting Classes and Methods

int OptionsAndChoices<T>(string prompt, List<T> options) where  T : IOption
{
    Console.WriteLine(prompt);
    int optionNumber = 0;

    foreach (var option in options)
    {
        optionNumber++;
        Console.WriteLine($"{optionNumber}) {option.Name}");
    }

    Console.Write("Option number: ");
    
    var index =  int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine();
    return index;
}

int MeatsAndVeggies(string prompt, List<string> options)
{
    Console.WriteLine(prompt);
    int optionNumber = 0;

    foreach (var option in options)
    {
        optionNumber++;
        Console.WriteLine($"{optionNumber}) {option}");
    }

    Console.Write("Option number (Type 0 to finish): ");

    var index = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine();
    return index;
}

void LoadData()
{
    meats = JsonConvert.DeserializeObject<MeatOption>(File.ReadAllText(@"Data\meats.json"));
    veggies = JsonConvert.DeserializeObject<VeggieOption>(File.ReadAllText(@"Data\veggies.json"));
    crustTypes = JsonConvert.DeserializeObject<Crust>(File.ReadAllText(@"Data\crust.json"));
    sauceTypes = JsonConvert.DeserializeObject<SauceTypes>(File.ReadAllText(@"Data\sauce.json"));
    toppings = JsonConvert.DeserializeObject<ToppingPrice>(File.ReadAllText(@"Data\toppings.json"));
    cheeses = JsonConvert.DeserializeObject<CheeseOption>(File.ReadAllText(@"Data\cheese.json"));

}

public class MeatOption
{
    public List<string> Meats { get; set; }
}

public class VeggieOption
{
    public List<string> Veggies { get; set; }
}

public class Crust
{
    public List<CrustType> CrustType { get; set; }
}

public class CrustType : IOption
{

    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Size> Sizes { get; set; }
}

public class Size : IOption
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Option : IOption
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Sauce : IOption
{

    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Option> Options { get; set; }
}

public class SauceTypes
{
    public List<Sauce> Sauces { get; set; }
}

public class Topping : IOption
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ToppingPrice
{
    public List<Topping> Toppings { get; set; }
}


public class Cheese : IOption
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class CheeseOption
{
    public List<Cheese> Cheese { get; set; }
}
#endregion