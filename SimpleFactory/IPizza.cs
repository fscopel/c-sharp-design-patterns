using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface IPizza
    {
        string Name { get; }
        List<string> Ingredients { get; }

        void Prepare();
        void Bake();
        void Cut();
        void Box();
        
    }
}
