using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        int result = number & mask;
        result = result >> 3;

        Console.WriteLine(result);

    }
}