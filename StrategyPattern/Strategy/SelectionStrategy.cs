using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    internal class SelectionStrategy : IToolStrategy
    {
        public void OnMouseDown()
        {
            Console.WriteLine("Selection tool selected");
        }

        public void OnMouseMove()
        {
            Console.WriteLine("Draw select area");
        }

        public void OnMouseUp()
        {
            Console.WriteLine("Commit select area");
        }
    }
}
