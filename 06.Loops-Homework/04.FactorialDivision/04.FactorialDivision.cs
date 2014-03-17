using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("Enter K and N in that (1<K<N) sequence : ");
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        for (int i =0; i<(n-k); i++)
        {
            result *= (n-i);
        }

        Console.WriteLine("N!/K! is: {0}",result);
    }
}
