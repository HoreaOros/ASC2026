

namespace VendingMachine_01.States
{
    internal class C: State
    {
        public C(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }
        public override void Nickle()
        {
            Console.WriteLine("Balance: 15 cents");
            vendingMachine.SetState(VendingMachine.D);
        }
        public override void Dime()
        {
            vendingMachine.SetState(VendingMachine.A);
            Console.WriteLine("Dispense product");
            Console.WriteLine("Balance: 0 cents");
        }
        public override void Quarter()
        {
            vendingMachine.SetState(VendingMachine.A);
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("You got a dime as change");
            Console.WriteLine("Balance: 0 cents");
        }
    }
}
