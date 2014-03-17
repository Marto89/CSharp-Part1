using System;

class MeanScore
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        decimal sum=0;
        decimal finalSum = 0;
        for (int i = 1; i <=numberN; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }
        finalSum = sum / numberN;
        Console.WriteLine(finalSum);
    }
}
