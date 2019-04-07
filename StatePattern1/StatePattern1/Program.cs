using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingmMachine obj = new WashingmMachine();
            obj.Washing();
            Console.ReadKey();
        }
    }
}
