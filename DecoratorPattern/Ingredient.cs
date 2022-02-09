using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Ingredient : IPizza
    {
        public Ingredient(IPizza pizza, string name, decimal price)
        {
            Name = name;
            pizza.Ingredients.Add(name);
            Ingredients = pizza.Ingredients;
            Price = pizza.Price + price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<string> Ingredients { get; set; }

        public override string ToString()
        {
            var toppingsBuilder = new StringBuilder();
            Ingredients.ForEach(o => toppingsBuilder.Append(o.ToString() + Environment.NewLine));
            return $"Pizza: {toppingsBuilder}Total price: ${Price}";
        }
    }
}
