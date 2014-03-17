using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char point='.';
        char asteriks='*';

       Console.Write(new string(point,n));
       Console.WriteLine(new string(asteriks,n));

        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string(point,n-1-i));
            Console.Write(asteriks);
            Console.Write(new string(point,n-1+i));
            Console.WriteLine(asteriks);
        }

        Console.WriteLine(new string(asteriks,n*2));
    }
}
