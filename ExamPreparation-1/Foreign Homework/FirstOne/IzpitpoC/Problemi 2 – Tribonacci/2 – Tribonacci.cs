using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstN = BigInteger.Parse(Console.ReadLine());
        BigInteger secondN = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());

        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger nextnumber = 0;

        if (numberN == 1)
        {
            Console.WriteLine(firstN);
            return;
        }
        else if (numberN == 2)
        {
            Console.WriteLine(secondN);
            return;
        }
        else if (numberN == 3)
        {
            Console.WriteLine(third);
            return;
        }

        for (BigInteger i = 3; i < numberN; i++)
        {
            nextnumber = firstN + secondN + third;
            firstN = secondN;
            secondN = third;
            third = nextnumber;
        }
        Console.WriteLine(nextnumber);
    }
}

