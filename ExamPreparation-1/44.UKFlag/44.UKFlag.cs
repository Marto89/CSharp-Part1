using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char asteriks='*';
        char point = '.';
        char slash = '/';
        char backslash = '\\';
        char dash = '-';
        char verticalDash='|';

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string(point,i));
            Console.Write(backslash);
            Console.Write(new string(point,n/2-i-1));
            Console.Write(verticalDash);
            Console.Write(new string(point, n / 2 - i - 1));
            Console.Write(slash);
            Console.WriteLine(new string(point, i));
        }

        Console.Write(new string(dash,n/2));
        Console.Write(asteriks);
        Console.WriteLine(new string(dash, n / 2));

        for (int i = n/2 - 1; i >= 0; i--)
        {
            Console.Write(new string(point,i));
            Console.Write(slash);
            Console.Write(new string(point,n/2-i-1));
            Console.Write(verticalDash);
            Console.Write(new string(point, n / 2 - i - 1));
            Console.Write(backslash);
            Console.WriteLine(new string(point, i));
        }
    }
}
