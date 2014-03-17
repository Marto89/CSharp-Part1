using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Title = "10.BitAtPosition";
        Console.Write("Enter the number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit number: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1<< p;
        int result = v & mask;
        result = result >> p;
        bool final = result == 1;

        Console.WriteLine("v={0};p={1}-> {2}.",v,p,final);

    }
}
