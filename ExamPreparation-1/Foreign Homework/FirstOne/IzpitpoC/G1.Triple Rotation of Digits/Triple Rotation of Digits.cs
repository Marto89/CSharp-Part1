using System;

class TripleRotationofDigits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            if (k >= 10)
            {
                int lastDigit = k % 10;
                int firstDigit = k / 10;
                k = int.Parse(""+lastDigit + firstDigit);
            }
        }
        Console.WriteLine(k);


    }
}

