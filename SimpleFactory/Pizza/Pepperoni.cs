using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class Pepperoni : BasePizza
    {
        public override string Name { get; }

        public override List<string> Ingredients { get; }

        public Pepperoni(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

       
    }
}

