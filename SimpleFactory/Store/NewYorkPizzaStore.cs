using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Pizza;

namespace SimpleFactory.Store
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(List<string> ingredients)
        {
            return new NewYorkPizza("New York Pizza", ingredients);
        }
    }
}
