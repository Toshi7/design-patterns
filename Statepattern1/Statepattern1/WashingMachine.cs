using System;

namespace StatePattern1
{
    class WashingmMachine
    {
        IState state = null;
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void Washing()
        {
            this.state = new Washing();
            while (this.state != null)
            {
                this.state.DoAction(this);
            }
            Console.WriteLine("終わりました。");
            Console.ReadKey();
        }
    }
}
