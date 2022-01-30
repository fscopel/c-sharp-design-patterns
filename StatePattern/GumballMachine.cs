using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class GumballMachine
    {
        public IGumballState HasCoinState { get; }
        public IGumballState NoCoinState { get; }
        public IGumballState SoldOutState { get; }
        public IGumballState SoldState { get; }
        public int GumballCount { get; private set; }

        IGumballState state;
        
        public GumballMachine(int numberOfGumballs)
        {
            HasCoinState = new HasCoinState(this);
            NoCoinState = new NoCoinState(this);
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            GumballCount = numberOfGumballs;
            state = NoCoinState;
        }

        public void InsertCoin()
        {
            state.InsertCoin();
        }
        
        public void ejectCoin()
        {
            state.EjectCoin();
        }
        
        public void turnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        
        public void SetState(IGumballState state)
        {
            this.state = state;
        }
        
        public void ReleaseBall()
        {
            Console.WriteLine("A Gumball comes rolling out...");
            if(GumballCount > 0)
            {
                GumballCount--;
            }
        }

    }
}
