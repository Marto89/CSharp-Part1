using System;
using System.Numerics;

class FactorialFormula2
{
    static void Main()
    {
        Console.WriteLine("Enter N and K in that (1<N<K) sequence : ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger sum1 = 1;
        BigInteger sum2 = 1;
        BigInteger sum3 = 1;
        for (int i = 1; i <=n; i++)
        {
            sum1 *= i;
        }
        for (int i = 1; i <=k; i++)
        {
            sum2 *= i;
        }
        for (int i = 1; i <=(k-n); i++)
        {
            sum3 *= i;
        }
        Console.WriteLine("The product of \"N!*K!/(K-N)!\" is: {0} ",sum1*sum2/sum3);
    }
}
