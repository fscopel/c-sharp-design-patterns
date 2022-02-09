using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PizzaDough
{
    public class BasePizza : IPizza
    {
        public BasePizza()
        {
            Ingredients = new List<string>();
            Price = 10.99m;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<string> Ingredients { get; set; }

    }
}
