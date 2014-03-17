using System;

class ExtractValueOfBit
{
    static void Main()
    {
        Console.Title = "11.ExtractValueOfBit";
        Console.Write("Enter the number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int result = i & mask;
        result = result >> b;


        Console.WriteLine("i={0};b={1} -> value={2}." ,i,b,result);
    }
}
