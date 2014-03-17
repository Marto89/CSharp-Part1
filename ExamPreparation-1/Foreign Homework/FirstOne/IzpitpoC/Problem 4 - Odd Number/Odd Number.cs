using System;

class OddNumber
{
    static void Main()
    {
        long N = int.Parse(Console.ReadLine());

        long result = long.Parse(Console.ReadLine());

        for (long i = 1; i < N; i++)
        {
            result ^= long.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

