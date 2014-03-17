using System;
using System.Numerics;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] characters=new int[n];
        BigInteger result=0;

        for (int i = 0; i < n; i++)
        {
            characters[i] = char.Parse(Console.ReadLine())-64;
        }
        for (int i = 0; i < n-1; i++)
        {
            result += characters[i] * (BigInteger)Math.Pow(26,n-(i+1));
        }
        result += characters[n-1];
        Console.WriteLine(result);
    }
}
