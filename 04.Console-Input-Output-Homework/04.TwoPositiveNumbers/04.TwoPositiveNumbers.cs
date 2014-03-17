using System;

class TwoPositiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first positive number: ");
        uint a = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second positive number: ");
        uint b = uint.Parse(Console.ReadLine());
        uint p = 0;

        for (uint i = a; (i <= b); i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p({0},{1})={2}",a,b,p);
    }
}
