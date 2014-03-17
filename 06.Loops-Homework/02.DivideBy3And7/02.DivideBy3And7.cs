using System;

class PrintNumber1ToN
{
    static void Main()
    {
        Console.Title = "01.PrintNumber1ToN";
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <=n; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}