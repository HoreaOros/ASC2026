
using System.Text;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 64;
            Console.WriteLine(Convert2Bin(n));
        }

        /// <summary>
        /// 47 => 64 = 2 ^ 6; ==> 32
        /// 64 => 128 = 2 ^ 7; ==> 64
        /// 1000000
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Convert2Bin(int n)
        {
            if (n == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            int p = 1;
            int d = 0;
            while (p <= n)
            {
                d++;
                p *= 2;
            }
            p /= 2;
            while (n > 0)
            {
                if(p <= n)
                {
                    n -= p;
                    sb.Append("1");
                }
                else
                    sb.Append("0");
                p /= 2;
                d--;
            }
            for (int i = 0; i < d; i++)
                sb.Append("0");
            return sb.ToString();
        }
    }
}
