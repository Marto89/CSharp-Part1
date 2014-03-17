using System;

class IntegersOnSingleLine
{
    static void Main()
    {
        Console.Write("Enter the last number :");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <=n; i++)
        {
            Console.WriteLine(i);
        }

    }
}