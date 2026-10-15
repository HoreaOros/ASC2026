//pbinfo #429
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static void p429()
    {
        int n;
        n = int.Parse(Console.ReadLine());

        int cnt0 = 0;
        int cnt1 = 0;
        while (n > 0)
        {
            int digit = n % 2;
            if (digit == 0)
                cnt0++;
            else if (digit == 1)
                cnt1++;
            n /= 2; // n = n / 2; 
        }
        Console.WriteLine($"{cnt0} {cnt1}");
    }
    static void Main(string[] args)
    {
        //p429();
        //p122();
        //p427();
        //p2318();
        // p947();
        Console.WriteLine(Power(2, 10) );
    }

    private static int Power(int b, int e)
    {
        if (e == 0)
            return 1;
        else if(e %2 == 1)
        {
            return b * Power(b, e - 1);
        }
        else
        {
            return Power(b * b, e / 2);
        }
    }

    private static void p947()
    {
        long n = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertTo(n, 16));
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
    private static void p2318()
    {
        StreamReader reader = new StreamReader("conversie_b_10.in");
        string line = reader.ReadLine();
        string[] parts = line.Split(' ');
        int n = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
        reader.Close();

        //1101 = 1*2^3 + 1*2^2 + 0*2^1 + 1*2^0 = 8 + 4 + 0 + 1 = 13
        int p = 1;
        int result = 0;
        while (n > 0)
        {
            int digit = n % 10;
            result += digit * p;
            p *= b;
            n /= 10;
        }

        using (StreamWriter writer = new StreamWriter("conversie_b_10.out"))
        {
            writer.WriteLine(result);
        }
    }

    private static void p427()
    {
        int n;
        int maxDigit = 0;
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int nr = int.Parse(Console.ReadLine());
            if(MaxDigit(nr) > maxDigit)
            {
                maxDigit = MaxDigit(nr);
            }
        }
        Console.WriteLine(maxDigit + 1);
    }

    private static int MaxDigit(int nr)
    {
        int maxDigit = 0;
        while (nr > 0)
        {
            int digit = nr % 10;
            if (digit > maxDigit)
                maxDigit = digit;
            nr /= 10;
        }
        return maxDigit;
    }

    private static void p122()
    {
        int a, b;
        string line = Console.ReadLine();
        string[] parts = line.Split(' '); 
        a = int.Parse(parts[0]);
        b = int.Parse(parts[1]);

        int a1 = CountBits(a);
        int b1 = CountBits(b);

        if(a1 > b1)
            Console.WriteLine(a);
        else if (b1 > a1)
            Console.WriteLine(b);
        else if(a < b)
            Console.WriteLine(a);
        else
            Console.WriteLine(b);
    }

    private static int CountBits(int n, int v = 1)
    {
        int count = 0;
        while (n > 0)
        {
            if (n % 2 == v)
                count++;
            n /= 2;
        }
        return count;
    }
}

