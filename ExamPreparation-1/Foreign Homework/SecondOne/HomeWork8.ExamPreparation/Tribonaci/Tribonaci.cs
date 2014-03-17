using System;
using System.Numerics;

class Tribonaci
{
    static void Main()
    {
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger next = first + second + third;
        if (n == 1)
        {
            next = first;
        }
        if (n == 2)
        {
            next = second;
        }
        if (n == 3)
        {
            next = third;
        }
        for (int i = 0; i < n - 4; i++)
        {
            first = second;
            second = third;
            third = next;
            next = first + second + third;
        }
        Console.WriteLine(next);
    }
}

