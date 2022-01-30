using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    internal class SoldOutState : IGumballState
    {
        GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Sold out");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sold out");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sold out");
        }
    }
}
