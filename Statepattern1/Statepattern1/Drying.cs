using System;
using System.Collections.Generic;
using System.Text;

namespace Statepattern1
{
    class Drying : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("乾燥しました。");
            washingMachine.SetState(null);
        }
    }
}
