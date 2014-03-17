using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char star='*';
        char dot='.';

        Console.Write(new string(dot,n/2+1));
        Console.Write(new string(star,n));
        Console.Write(new string(dot, n / 2 + 1));
        Console.WriteLine();
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(dot,n/2-i));
            Console.Write(star);
            Console.Write(new string(dot, n / 2 + i));
            Console.Write(star);
            Console.Write(new string(dot, n / 2 + i));
            Console.Write(star);
            Console.Write(new string(dot, n / 2 - i));
            Console.WriteLine();
        }
        Console.Write(new string(star,n*2+1));
        Console.WriteLine();
        for (int i = 1; i <=n-1; i++)
        {
            Console.Write(new string(dot,i));
            Console.Write(star);
            Console.Write(new string(dot,(n-1)-i));
            Console.Write(star);
            Console.Write(new string(dot, (n - 1) - i));
            Console.Write(star);
            Console.Write(new string(dot, i));
            Console.WriteLine();
        }
        Console.Write(new string(dot,n));
        Console.Write(star);
        Console.WriteLine(new string(dot, n));
    }
}
