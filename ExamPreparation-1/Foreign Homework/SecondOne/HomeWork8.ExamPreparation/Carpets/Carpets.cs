using System;

class Carpets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int limit1;
        int limit2;
        if ((n/2)%2 == 1)
        {
            limit1 = 1;
            limit2 = 0;
        }
        else
        {
            limit1 = 0;
            limit2 = 1;
        }

        for (int row = 1; row <= n; row++)
        {
            for (int cow = 1; cow <= n; cow++)
            {
                if (((row + cow >= (n / 2) + 1) && (cow - row <= n / 2)) && ((row - cow <= n / 2) && (row + cow <= (n + (n / 2) + 1))))
                {
                    if ((row <= n / 2 && cow <= n / 2) || (row >= (n / 2) + 1 && cow >= (n / 2) + 1))
                    {
                        if ((row + cow) % 2 == limit1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else
                    {
                        if ((row + cow)%2 == limit2)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }
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

