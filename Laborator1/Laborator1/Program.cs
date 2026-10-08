namespace Laborator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti un număr natural: ");
            n = int.Parse(Console.ReadLine());


            Stack<int> st = new Stack<int>();
            while (n > 0)
            {
                st.Push(n % 2);
                n = n / 2;
            }
            while (st.Count > 0)
                Console.Write(st.Pop());
            Console.WriteLine();
            
        }
    }
}
