using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class Spinning : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("脱水しました。");
            washingMachine.SetState(new Drying());
        }
    }
}
