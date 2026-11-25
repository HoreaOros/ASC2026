namespace VendingMachine_01
{
    internal class D: State 
    {
        public D(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }

        public override void Dime()
        {
            vendingMachine.SetState(new A(vendingMachine));
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("Balance: 0 cents");

        }

        public override void Nickle()
        {
            vendingMachine.SetState(new A(vendingMachine));
            Console.WriteLine("Dispense product");
            Console.WriteLine("Balance: 0 cents");
        }

        public override void Quarter()
        {
            vendingMachine.SetState(new B(vendingMachine));
            Console.WriteLine("Dispense product");
            Console.WriteLine("You got a nickel as change");
            Console.WriteLine("You got a dime as change");
            Console.WriteLine("Balance: 5 cents");
        }
    }
}