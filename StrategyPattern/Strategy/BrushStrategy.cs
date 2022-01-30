using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal class BrushStrategy : IToolStrategy
    {
        public void OnMouseDown()
        {
            Console.WriteLine("Brush tool selected");
        }

        public void OnMouseMove()
        {
            Console.WriteLine("Create line");
        }

        public void OnMouseUp()
        {
            Console.WriteLine("Line creating stopped");
        }
    }
}
