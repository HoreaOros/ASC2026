using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine_01.States;
namespace VendingMachine_01
{
    internal class VendingMachine
    {
        public static A A;
        public static B B;
        public static C C;
        public static D D;
        State state;
        public VendingMachine()
        {
            A = new A(this);
            B = new B(this);
            C = new C(this);
            D = new D(this);
            state = A;
        }
        public void SetState(State state)
        {
            this.state = state;
        }
        public void InsertNickle()
        {
            state.Nickle();
        }
        public void InsertDime()
        {
            state.Dime();
        }
        public void InsertQuarter()
        {
            state.Quarter();
        }
    }
}
