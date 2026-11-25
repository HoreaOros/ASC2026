using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine_01
{
    internal class VendingMachine
    {
        State state;
        public VendingMachine()
        {
            state = new A(this);
        }
        public void SetState(State state)
        {
            this.state = state;
        }
        public void N()
        {
            state.Nickle();
        }
        public void D()
        {
            state.Dime();
        }
        public void Q()
        {
            state.Quarter();
        }
    }
}
