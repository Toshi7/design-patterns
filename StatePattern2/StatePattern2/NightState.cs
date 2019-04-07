using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class NightState : IState
    {
        private static NightState singleton = new NightState();
        private NightState()
        {
        }
        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoClock(IContext context, int hour)
        {
            if (9 <= hour || hour < 17)
            {
                context.ChangeState(DayState.GetInstance);
            }
        }

        public void DoUse(IContext context, int hour)
        {
            context.RecordLog("非常：夜間の金庫使用！");
        }

        public void DoAlarm(IContext context, int hour)
        {
            context.CallSecurityCenter("非常ベル（夜間）");
        }


        public void DoPhone(IContext context, int hour)
        {
            context.CallSecurityCenter("夜間の通話録音");
        }
        public string ToString()
        {
            return "[夜間]";
        }
    }
}
