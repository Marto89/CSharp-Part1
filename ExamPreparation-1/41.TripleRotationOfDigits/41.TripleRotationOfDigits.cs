using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int? k = int.Parse(Console.ReadLine());
        int? firstRotation = 0;
        int? secondRotation = 0;
        int? thirdRotation = 0;
        int length = k.ToString().Length;

        for (int i = 1; i <= 3; i++)
        {
            if (i == 1)
            {
                firstRotation = k % 10;
                if (firstRotation == 0)
                {
                   firstRotation=null;
                }
            }
            if (i == 2)
            {
                secondRotation = k % 10;
                if (secondRotation==0)
                {
                    secondRotation = null;
                }
            }
            if (i == 3)
            {
                thirdRotation = k % 10;
                if (thirdRotation == 0)
                {
                   thirdRotation = null;
                }
            }
            k = k / 10;
        }
        if (k == 0)
        {
            k = null;
        }
        if (length != 2)
        {
            Console.WriteLine("{0}{1}{2}{3}", thirdRotation, secondRotation, firstRotation, k);
        }
        else
        {
            Console.WriteLine("{0}{1}",firstRotation,secondRotation);
        }
    }
}
