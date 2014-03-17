using System;

class SetValue
{
    static void Main()
    {
        Console.Title = "12.SetValue";

        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of the bit(0 or 1): "); 
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result;

        if (v == 0)
        {           
            mask = ~ mask;
            result = mask & n;

            Console.WriteLine("n={0},p={1},v={2} -> {3}", n, p, v, result);
        }
        else
        {
            result = mask | n;

            Console.WriteLine("n={0},p={1},v={2} -> {3}", n, p, v, result);
        }       
    }
}