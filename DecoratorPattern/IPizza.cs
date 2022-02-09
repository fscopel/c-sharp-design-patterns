using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IPizza
    {
        List<string> Ingredients { get; set; }
        decimal Price { get; set; }
        public string Name { get; set; }
    }

}
