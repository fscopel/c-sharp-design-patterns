using SimpleFactory.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public enum PizzaType
    {
        Pepperoni,
        Chicken
    }
    
    internal class SimplePizzaFactory
    {
        internal static IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Pepperoni:
                    return new Pepperoni("Pepperoni", new List<string> { "Pepperoni", "Cheese" });
                    
                case PizzaType.Chicken:
                    return new BBQChicken("BBQ Chicken", new List<string> { "Chicken", "BBQ", "Cheese" });
                default:
                    return null;
            }
        }
    }
}
