using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine_01
{
    internal class B: State
    {
        public B(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }
        public override void Nickle()
        {
            Console.WriteLine("Balance: 10 cents");
            vendingMachine.SetState(new C(vendingMachine));
        }
        public override void Dime()
        {
            Console.WriteLine("Balance: 15 cents");
            vendingMachine.SetState(new D(vendingMachine));
        }
        public override void Quarter()
        {
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a dime as change");
            Console.WriteLine("Balance: 0 cents");
        }
    }
}
