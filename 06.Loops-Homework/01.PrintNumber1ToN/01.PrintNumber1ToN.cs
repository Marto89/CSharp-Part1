using System;

class PrintNumber1ToN
{
    static void Main()
    {
        Console.Title = "01.PrintNumber1ToN";
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());

        for ( int number = 1; number <= n ; number++)
        {
            Console.WriteLine(number);           
        }
    }
}