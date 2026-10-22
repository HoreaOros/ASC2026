


namespace Laborator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numar = "1BAF.EA";
            // 1*16^3 + B * 16^2 + A*16^1+F*16^0 + E*16^(-1)+A*16^-2

            // (((0 * 16 + 1) * 16 + 11) * 16 + 10) * 16 + 15
            int baza = 16;

            Console.WriteLine(ConvertFrom(numar, baza));

        }

        private static int ConvertFrom(string numar, int baza)
        {
            int pos = numar.IndexOf('.');
            if (pos == -1)
            {
                return ConvertIntegerFrom(numar, baza);
            }



            return 0;
        }

        private static int ConvertIntegerFrom(string numar, int baza)
        {
            int result = 0;
            foreach (char c in numar)
            {
                result = result * 16 + DigitToNumber(c);
            }
            return result;
        }

        private static int DigitToNumber(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';
            

            if(c >= 'A' && c <= 'F')
                return c - 'A' + 10;

            throw new FormatException("Illegal digit");
        }
    }
}
