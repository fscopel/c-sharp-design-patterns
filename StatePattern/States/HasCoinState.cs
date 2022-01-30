using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    internal class HasCoinState : IGumballState
    {
        GumballMachine _machine;

        public HasCoinState(GumballMachine machine)
        {
            _machine = machine;    
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Ejecting coin");
            _machine.SetState(_machine.NoCoinState);    
        }

        public void InsertCoin()
        {
            Console.WriteLine("You can't insert another coin. There is a coin already.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning the crank...");
            _machine.SetState(_machine.SoldState);
        }
    }
}
