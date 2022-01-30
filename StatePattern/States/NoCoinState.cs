using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    internal class NoCoinState : IGumballState
    {
        GumballMachine _machine;

        public NoCoinState(GumballMachine machine)
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
            Console.WriteLine("Coin excepted");
            _machine.SetState(_machine.HasCoinState);
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
