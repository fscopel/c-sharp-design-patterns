using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizza
{
    public abstract class BasePizza : IPizza
    {
        public abstract string Name { get; }

        public abstract List<string> Ingredients { get; }

        public void Prepare()
        {
            Console.WriteLine($"Prepare {Name} pizza");
        }

        public void Bake()
        {
            Console.WriteLine($"Bake {Name} pizza");
        }

        public void Cut()
        {
            Console.WriteLine($"Cut {Name} pizza");
        }

        public void Box()
        {
            Console.WriteLine($"Box {Name} pizza");
        }
    }
}
