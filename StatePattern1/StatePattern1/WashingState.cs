using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class WashingState : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("洗いました。");
            washingMachine.SetState(new RinsingState());
        }
    }
}
