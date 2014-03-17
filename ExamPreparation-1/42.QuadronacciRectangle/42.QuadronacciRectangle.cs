using System;
using System.Numerics;

class QuadronacciRectangle
{
    static void Main()
    {
        BigInteger firstNumber = int.Parse(Console.ReadLine());
        BigInteger secondNumber = int.Parse(Console.ReadLine());
        BigInteger thirdNumber = int.Parse(Console.ReadLine());
        BigInteger fourthNumber= int.Parse(Console.ReadLine());
        BigInteger fifthNumber;

        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        BigInteger[]allNumbers=new BigInteger [rows*columns];
        allNumbers[0] = firstNumber;
        allNumbers[1] = secondNumber;
        allNumbers[2] = thirdNumber;
        allNumbers[3] = fourthNumber;

        for (int i = 4; i <rows*columns; i++)
        {
            fifthNumber=firstNumber+secondNumber+thirdNumber+fourthNumber;
            firstNumber=secondNumber;
            secondNumber=thirdNumber;
           thirdNumber=fourthNumber;
            fourthNumber=fifthNumber;
            allNumbers[i]=fifthNumber;
        }
        int indicator = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j <=columns; j++)
            {
                if (j != columns)
                {
                    Console.Write("{0} ", allNumbers[indicator]);
                }
                else
                {
                    Console.Write(allNumbers[indicator]);
                }
                    indicator++;
            }
            Console.WriteLine();
        }
    }
}
