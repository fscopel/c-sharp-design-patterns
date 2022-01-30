using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal interface IToolState
    {
        void OnMouseDown();
        void OnMouseUp();
        void OnMouseMove();

    }
}
