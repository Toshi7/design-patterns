using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    interface IState 
    {
        void DoClock(IContext context, int hour);
        void DoUse(IContext context, int hour);
        void DoAlarm(IContext context, int hour);
        void DoPhone(IContext context, int hour);
    }
}
