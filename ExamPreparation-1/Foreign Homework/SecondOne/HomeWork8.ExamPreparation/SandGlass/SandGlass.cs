using System;

class SandGlass
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int cow = 0; cow < n; cow++)
            {
                if ((row - cow <= 0 && row + cow <= n-1) || (row + cow >= n - 1 && row - cow >=0))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

