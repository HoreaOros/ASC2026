using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DASM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            F(10);
        }

        private static void F(int v)
        {
            Console.WriteLine(v);
            v++;
            Console.WriteLine();
            v = v + 2;
        }
    }
}
