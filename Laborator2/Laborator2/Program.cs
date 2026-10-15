//pbinfo #429
using System;
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
        p122();
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

