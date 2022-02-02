using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(List<string> ingredients)
        {
            var pizza = CreatePizza(ingredients);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract IPizza CreatePizza(List<string> ingredients);
    }
}
