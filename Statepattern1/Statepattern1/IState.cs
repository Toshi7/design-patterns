using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    interface IState
    {
        void DoAction(WashingmMachine washingMachine);
    }
}
