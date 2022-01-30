using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    internal class SoldState : IGumballState
    {

        GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            _machine.ReleaseBall();
            if (_machine.GumballCount > 0)
            {
                _machine.SetState(_machine.NoCoinState);
            }
            else
            {
                Console.WriteLine("oops out of gumballs");
                _machine.SetState(_machine.SoldOutState);
            }

            
        }

        public void EjectCoin()
        {
            Console.WriteLine("Coin was already used.");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Need to insert coin first");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice wont work.");
        }
    }
}
