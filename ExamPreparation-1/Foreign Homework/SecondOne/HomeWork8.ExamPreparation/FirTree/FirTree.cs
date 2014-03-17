using System;

class FirTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int heigth = n - 1;
        int width = (n - 1) + (n - 2);

        for (int row = 1; row <= heigth; row++)
        {
            for (int cow = 1; cow <= width; cow++)
            {
                if (row + cow >= n && cow - row <= n-2)
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
        for (int row = 1; row <= width; row++)
        {
            if (row == n - 1)
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

