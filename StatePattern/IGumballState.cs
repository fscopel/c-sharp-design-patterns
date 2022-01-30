﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface IGumballState
    {
        void InsertCoin();
        void EjectCoin();
        void TurnCrank();
        void Dispense();
    }
}
