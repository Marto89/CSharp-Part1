using System;
using System.Numerics;

class TribonacciTriangle
{
    static void Main()
    {
        checked
        {
            BigInteger firstNumber = int.Parse(Console.ReadLine());
            BigInteger secondNumber = int.Parse(Console.ReadLine());
            BigInteger thirdNumber = int.Parse(Console.ReadLine());

            int lNumber = int.Parse(Console.ReadLine());

            int result = 0;
            int counter = 1;
            for (int i = 1; i <= lNumber; i++)
            {
                result = result + counter;
                counter++;
            }

            BigInteger[] tribonacciSequence = new BigInteger [result];
            tribonacciSequence[0] = firstNumber;
            tribonacciSequence[1] = secondNumber;
            tribonacciSequence[2] = thirdNumber;

            BigInteger fourthNumber = 0;
            for (int i = 3; i < result; i++)
            {
                fourthNumber = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = fourthNumber;
                tribonacciSequence[i] = fourthNumber;
            }
            int indicator = -1;
            for (int i = 0; i < lNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    indicator++;
                    if (j != i)
                    {
                        Console.Write(tribonacciSequence[indicator] + " ");
                    }
                    else
                    {
                        Console.Write(tribonacciSequence[indicator]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
