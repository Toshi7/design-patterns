using System;
using System.Collections.Generic;
using System.Text;

namespace Statepattern1
{
    class Rinsing : IState
    {
        public void DoAction(WashingmMachine washingMachine)
        {
            Console.WriteLine("すすぎました。");
            washingMachine.SetState(new Spinning());
        }
    }
}
