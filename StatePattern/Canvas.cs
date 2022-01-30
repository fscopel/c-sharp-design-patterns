using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    
    internal class Canvas
    {
        internal IToolStrategy toolStrategy { get; set; }

        public Canvas(IToolStrategy startingStrategy)
        {
            toolStrategy = startingStrategy;
        }

        internal void OnMouseDown()
        {
            toolStrategy.OnMouseDown();
        }

        internal void OnMouseDrag()
        {
            toolStrategy.OnMouseMove();
        }

        internal void OnMouseUp()
        {
            toolStrategy.OnMouseUp();
        }
    }
}
