using VendingMachine_01;
namespace VendingMachine_01.States
{
    internal class A: State
    {
        public A(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }
        public override void Nickle()
        {
            Console.WriteLine("Balance: 5 cents");
            vendingMachine.SetState(VendingMachine.B);
        }
        public override void Dime()
        {
            Console.WriteLine("Balance: 10 cents");
            vendingMachine.SetState(VendingMachine.C);
        }
        public override void Quarter()
        {
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("Balance: 0 cents");
        }
    }
}
