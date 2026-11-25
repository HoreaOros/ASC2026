namespace VendingMachine_01.States;

internal class D: State 
{
    public D(VendingMachine vendingMachine) : base(vendingMachine)
    {
    }

    public override void Dime()
    {
        vendingMachine.SetState(VendingMachine.A);
        Console.WriteLine("Dispense product");
        Console.WriteLine("You got a nickel as change");
        Console.WriteLine("Balance: 0 cents");

    }

    public override void Nickle()
    {
        vendingMachine.SetState(VendingMachine.A);
        Console.WriteLine("Dispense product");
        Console.WriteLine("Balance: 0 cents");
    }

    public override void Quarter()
    {
        vendingMachine.SetState(VendingMachine.B);
        Console.WriteLine("Dispense product");
        Console.WriteLine("You got a nickel as change");
        Console.WriteLine("You got a dime as change");
        Console.WriteLine("Balance: 5 cents");
    }
}