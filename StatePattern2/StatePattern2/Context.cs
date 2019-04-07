using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    interface IContext
    {
        void SetClock(int hour);
        void ChangeState(IState state);
       void CallSecurityCenter(string msg);
       void RecordLog(string msg);
    }
}
