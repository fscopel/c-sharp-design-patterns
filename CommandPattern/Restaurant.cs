var cook = new Cook();
var bartender = new Bartender();
var bobWaiter = new Waiter(cook, bartender);
var customer = new Customer(bobWaiter);

customer.OrderFood("Pepperoni Pizza");
customer.OrderDrink("Iced tea");
customer.ThankYouThatsAll();

Console.ReadLine();


class Customer
{

    IWaitInvoker _waiter;

    public Customer(IWaitInvoker waiter)
    {
        _waiter = waiter;
    }

    public void OrderFood(string dishName)
    {
        var foodOrderCommand = new OrderFoodCommand(dishName);
        _waiter.TakeFoodOrder(foodOrderCommand);
    }

    public void OrderDrink(string bevName)
    {
        var beverageCommand = new OrderBeverageCommand(bevName);
        _waiter.TakeDrinkOrder(beverageCommand);
    }

    public void ThankYouThatsAll()
    {
        _waiter.ExecuteCommands();
    }

}

class Waiter : IWaitInvoker
{
    IStaff _cook;
    IStaff _bartender;

    public List<IOrderCommand> allCommands { get; private set; }

    public Waiter(IStaff cook, IStaff preparer)
    {
        _cook = cook;
        _bartender = preparer;
        allCommands = new List<IOrderCommand>();
    }

    public void TakeFoodOrder(IOrderCommand command)
    {
        command.SetPreparer(_cook);
        allCommands.Add(command);

    }

    public void TakeDrinkOrder(IOrderCommand command)
    {
        command.SetPreparer(_bartender);
        allCommands.Add(command);
    }

    public void ExecuteCommands()
    {
        foreach (var cmd in allCommands)
        {
            cmd.Execute();
        }
    }
}


class Cook : IStaff
{
    public void Prepare(string item)
    {
        Console.WriteLine($"Your {item} is ready");
    }
}


class Bartender : IStaff
{
    public void Prepare(string item)
    {
        Console.WriteLine($"Your {item} is ready");
    }

}

public interface IStaff
{
    void Prepare(string item);
}

public interface IOrderCommand
{
    void SetPreparer(IStaff preparer);
    void Execute();
}

public interface IWaitInvoker
{
    List<IOrderCommand> allCommands { get; }
    void TakeFoodOrder(IOrderCommand command);
    void TakeDrinkOrder(IOrderCommand command);
    void ExecuteCommands();
}

public class OrderBeverageCommand : IOrderCommand
{
    string _beverage;
    IStaff _preparer;

    public OrderBeverageCommand(string beverage)
    {
        _beverage = beverage;
    }

    public void Execute()
    {
        _preparer.Prepare(_beverage);
    }

    public void SetPreparer(IStaff preparer)
    {
        _preparer = preparer;
    }
}


public class OrderFoodCommand : IOrderCommand
{
    string _dishName;
    IStaff _preparer;

    public OrderFoodCommand(string dishName)
    {
        _dishName = dishName;
    }

    public void Execute()
    {
        _preparer.Prepare(_dishName);
    }

    public void SetPreparer(IStaff preparer)
    {
        _preparer = preparer;
    }
}

