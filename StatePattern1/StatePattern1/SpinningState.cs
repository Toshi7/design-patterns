using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class SpinningState : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("脱水しました。");
            washingMachine.SetState(new DryingState());
        }
    }
}
