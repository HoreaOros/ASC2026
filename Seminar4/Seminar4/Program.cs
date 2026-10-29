
using System.Text;

namespace Seminar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatori pe biti

            // 0010101010101 & (SI), | (SAU), ^ (XOR)
            // 1010100100110 ~ (complement), <<, >> (deplasare)
            // -----------------
            //
            // & | 0 1
            // -------
            // 0 | 0 0  
            // 1 | 0 1
            // a = 1011
            // b = 0110
            //a&b= 0010
            //a|b= 1111
            //a^b= 1101

            // m = 1010 XOR
            // k = 0001
            // ---------
            // c = 1011 XOR
            // k = 0001
            // ---------
            // m'= 1010, (m XOR k) XOR k = m

            // m  = 1010
            // ~m = 0101
            // m = 01010101
            // m << 2 ===>  01010100 <==> m * (2^k)
            // m = m * 2; m = m << 1;
            // 01010100 = 1*2^6 + 1*2^4 + 1*2^2 = 84
            // 10101000 = 1*2^7 + 1*2^5 + 1*2^3 = 168  

            uint a = 2598746;
            Console.WriteLine(BitPattern(a));

            uint b = 0b101010101;
            uint x = 0xCAFE;
            Console.WriteLine(b);

            Console.WriteLine(Convert.ToUInt32("0101001", 2));

            Console.WriteLine($"{15:b}");

            Console.WriteLine($"{x:b}");
            SetBit(ref x, 8);
            Console.WriteLine($"{x:b}");
            ResetBit(ref x, 8);


        }

        private static void ResetBit(ref uint x, int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Seteaza bitul de pe pozitia pos din x la valoarea 1
        /// </summary>
        private static void SetBit(ref uint x, int pos)
        {
            // 110000000000
            // 109876543210
            // ------------
            // 011010101011

            x = x | (1u << pos);
        }

        // 0101011010
        // 0000000001
        private static string BitPattern(uint a)
        {
            StringBuilder sb = new StringBuilder();
            while(a > 0)
            {
                sb.Insert(0, a & 1u);
                a >>= 1;
            }
            return sb.ToString();
        }

    }
}
