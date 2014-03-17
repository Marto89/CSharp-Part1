using System;

    class SumOfSeries
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers N and X : ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double result =1;
        double sum1 = 1;
        double sum2=1;
        for (int i = 1; i <= n; i++)
        {        
             sum1 *= i;
            
             sum2 = sum1 / (int)Math.Pow(x, i);
          
                result+=sum2;                          
        }
        Console.WriteLine("1 + 1!/X + 2!/X2 + … + N!/XN = {0}",result);
    }
}
