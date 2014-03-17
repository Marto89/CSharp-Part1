using System;
using System.Numerics;

class QuadronacciRectangle
{
    static void Main()
    {        
       BigInteger firstN = BigInteger.Parse(Console.ReadLine());
        BigInteger secondN = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdN = BigInteger.Parse(Console.ReadLine());
        BigInteger fourdN = BigInteger.Parse(Console.ReadLine());

        BigInteger R = BigInteger.Parse(Console.ReadLine());
        BigInteger C = BigInteger.Parse(Console.ReadLine());

        BigInteger nextNumber = 0;

        if (C == 4)
        {
            Console.WriteLine("{0} {1} {2} {3} ",firstN,secondN,thirdN,fourdN);
        }

        if (C > 4)
        {
            Console.Write("{0} {1} {2} {3} ", firstN, secondN, thirdN, fourdN);
        }
        for (BigInteger i = 0; i < (R*C)-4; i++)
        {
            nextNumber = firstN + secondN + thirdN + fourdN;
            firstN = secondN;
            secondN = thirdN;
            thirdN = fourdN;
            fourdN = nextNumber;

            if((i+4) % C==0 && i>0)
            {
                Console.WriteLine();
            }
            if ((i + 5) % C == 0 && i > 0)
            {
                Console.Write(nextNumber);
            }
            else
            {
                Console.Write(nextNumber + " ");      
            }            
        }
        Console.WriteLine();
    }
}

