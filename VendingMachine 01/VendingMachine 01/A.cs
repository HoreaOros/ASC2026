using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine_01
{
    internal class A: State
    {
        public A(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }
        public override void Nickle()
        {
            Console.WriteLine("Balance: 5 cents");
            vendingMachine.SetState(new B(vendingMachine));
        }
        public override void Dime()
        {
            Console.WriteLine("Balance: 10 cents");
            vendingMachine.SetState(new C(vendingMachine));
        }
        public override void Quarter()
        {
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("Balance: 0 cents");
        }
    }
}
