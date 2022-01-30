using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    internal class WinnerState : IGumballState
    {
        GumballMachine _machine;

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new NotImplementedException();
        }

        public void InsertCoin()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
