using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public class BBQChicken : BasePizza
    {
        public override string Name { get; }

        public override List<string> Ingredients { get; }

        public BBQChicken(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

    }
}

