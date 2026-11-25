namespace VendingMachine_01
{
    internal abstract class State
    {
        protected VendingMachine vendingMachine;

        public State(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }
        public abstract void Nickle();
        public abstract void Dime();
        public abstract void Quarter();
    }
}