using System;
using System.Numerics;

class NCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter a integer n (n>=0): ");
        int n = int.Parse(Console.ReadLine());
        double sum;

        BigInteger n2Factorial =1;    
        for (int i = 1; i <=(2*n); i++)
        {
            n2Factorial *= i;      
        }
        BigInteger nFactorial = 1; 
        for (int i = 1; i <=n; i++)
        {
            nFactorial *= i;
        }
        sum = (double)n2Factorial / ((double)nFactorial*(n+1)*(double)nFactorial);
        Console.WriteLine("The {0}th Catalan number is: {1}",n,sum);
    }
}
