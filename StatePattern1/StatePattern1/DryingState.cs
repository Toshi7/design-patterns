using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class DryingState : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("乾燥しました。");
            washingMachine.SetState(null);
        }
    }
}
