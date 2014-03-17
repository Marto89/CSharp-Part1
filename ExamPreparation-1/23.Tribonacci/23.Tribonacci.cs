using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        checked
        {      
        BigInteger firstNumber = int.Parse(Console.ReadLine());
        BigInteger secondNumber =int.Parse(Console.ReadLine());
        BigInteger thirdNumber = int.Parse(Console.ReadLine());
        BigInteger fourthNumber=0;

        int nNumber=int.Parse(Console.ReadLine());
        if (nNumber == 1)
        {
            Console.WriteLine(firstNumber); return;
        }
        if (nNumber==2)
        {
            Console.WriteLine(secondNumber); return;
        }
        if (nNumber == 3)
        {
            Console.WriteLine(thirdNumber); return;
        }

        for (int i = 3; i <nNumber; i++)
        {
            fourthNumber = firstNumber + secondNumber + thirdNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = fourthNumber;
        }
        
        Console.WriteLine(fourthNumber);
        }
    }   
}