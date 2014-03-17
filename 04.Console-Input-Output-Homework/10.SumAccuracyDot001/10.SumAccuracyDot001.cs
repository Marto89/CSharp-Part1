using System;

class SumAccuracyDot001
{
    static void Main()
    {
        Console.WriteLine("Enter last number:");
        int lastNumber = int.Parse(Console.ReadLine());
        double counter = 2d;
        double sum = 1d;
        int sign = 1;
        for (int i = 0; i < lastNumber; i++)
        {
            sum = sum + (1d / counter) * sign;
            sign = sign * (-1);
            counter++;
        }
        Console.WriteLine("sum = {0:F3}", sum);
    }
}