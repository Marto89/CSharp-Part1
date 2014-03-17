using System;
using System.Numerics;
class TribonacciTriangle
{
    static void Main()
    {
        BigInteger firstN = BigInteger.Parse(Console.ReadLine());
        BigInteger secondN = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdN = BigInteger.Parse(Console.ReadLine());

        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger nextnumber = 0;
        Console.WriteLine(firstN);
        Console.WriteLine(secondN + " " + thirdN);

        for (int i = 3; i <= numberN; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                nextnumber = firstN + secondN + thirdN;
                firstN = secondN;
                secondN = thirdN;
                thirdN = nextnumber;
                Console.Write(nextnumber + " ");
            }
            Console.WriteLine();
        }
        
    }
}

