using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine_01
{
    internal class C: State
    {
        public C(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }
        public override void Nickle()
        {
            Console.WriteLine("Balance: 15 cents");
            vendingMachine.SetState(new D(vendingMachine));
        }
        public override void Dime()
        {
            vendingMachine.SetState(new A(vendingMachine));
            Console.WriteLine("Dispense product");
            Console.WriteLine("Balance: 0 cents");
        }
        public override void Quarter()
        {
            vendingMachine.SetState(new A(vendingMachine));
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("You got a dime as change");
            Console.WriteLine("Balance: 0 cents");
        }
    }
}
