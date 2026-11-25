using VendingMachine_01;

var vendingMachine = new VendingMachine();


Console.WriteLine("Welcome to the Vending Machine!");
Console.WriteLine("Product price: 20 cents");
Console.WriteLine();
bool done = false;
while (!done)
{
    Console.WriteLine("Insert a coin:");
    Console.WriteLine("1 - Nickel  (5 cents)");
    Console.WriteLine("2 - Dime    (10 cents)");
    Console.WriteLine("3 - Quarter (25 cents)");
    Console.WriteLine("4 - Quit");
    Console.Write("Your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You inserted a nickle.");
            vendingMachine.N();
            break;

        case 2:
            Console.WriteLine("You inserted a dime.");
            vendingMachine.D();
            break;

        case 3:
            Console.WriteLine("You inserted a quarter.");
            vendingMachine.Q();
            break;
        case 4:
            Console.WriteLine("Thank you for using the Vending Machine. Goodbye!");
            done = true;
            break;
        default:
            Console.WriteLine("Invalid coin! Try again.");
            continue;
    }
}