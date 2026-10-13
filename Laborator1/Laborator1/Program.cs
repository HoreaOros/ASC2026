using System;
using System.Collections.Generic;
using System.Text;
namespace Laborator1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            long n;
            Console.WriteLine("Introduceti un număr natural: ");
            n = long.Parse(Console.ReadLine());


            string result = ConvertTo(n, 16);

            Console.WriteLine(result);
            
        }

        private static string ConvertTo(long n, int b)
        {
            Stack<long> st = new Stack<long>();
            while (n > 0)
            {
                st.Push(n % b);
                n = n / b;
            }
            

            StringBuilder sb = new StringBuilder();
            while (st.Count > 0)
            {
                long v = st.Pop();
                if (v <= 9)
                    sb.Append(v.ToString());
                else
                    sb.Append((char)('A' + (v - 10)));
            }
            return sb.ToString();


        }
    }
}
