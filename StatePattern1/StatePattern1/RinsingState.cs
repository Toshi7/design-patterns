using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class RinsingState : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("すすぎました。");
            washingMachine.SetState(new SpinningState());
        }
    }
}
