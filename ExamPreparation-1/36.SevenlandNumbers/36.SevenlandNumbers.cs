using System;

class SevenlandNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 666)
        {
            n = 1000;
        }
        else if ((n % 100) == 66)
        {
            n += 34;
        }
        else if (n % 10 != 6)
        {
            n++;
        }
        else if (n % 10 == 6)
        {
            n += 4;
        }

        Console.WriteLine(n);
    }
}