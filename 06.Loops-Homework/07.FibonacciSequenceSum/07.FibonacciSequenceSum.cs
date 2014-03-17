using System;
using System.Numerics;

class FibonacciSequenceSum
{
    static void Main()
    {
        Console.Write("Enter a number N from sequence of Fibonacci: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger x = 0;
        BigInteger y = 1;
        BigInteger z;
        BigInteger result = 1;
        if (n !=0 && n!=1)
        {
            for (int i = 2; i < n; i++)
            {
                z = x + y;
                x = y;
                y = z;
                result += z;
            }
            Console.WriteLine("The sum of the first N members of the sequence of Fibonacci is : {0}", result);
           
        }
        else
        {
            Console.WriteLine("The sum of the first N members of the sequence of Fibonacci is : {0}", x);
        }
    }
}