using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class DayState : IState
    {
        private static DayState singleton = new DayState();
        private DayState()
        {
        }
        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoClock(IContext context, int hour)
        {
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance);
            }
        }

        public void DoUse(IContext context, int hour)
        {
            context.RecordLog("金庫使用（昼間）");
        }

        public void DoAlarm(IContext context, int hour)
        {
            context.CallSecurityCenter("非常ベル（昼間）");
        }


        public void DoPhone(IContext context, int hour)
        {
            context.CallSecurityCenter("通常の通話（通話）");
        }
        public string toString()
        {
            return "[昼間]";
        }
    }
}
