using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger nNumber = firstNumber + secondNumber;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(nNumber);

        for (int i = 3; i <=100; i++)
        {
            firstNumber = secondNumber;
            secondNumber = nNumber;
            nNumber = firstNumber + secondNumber;
            Console.WriteLine(nNumber);
        }
    }
}