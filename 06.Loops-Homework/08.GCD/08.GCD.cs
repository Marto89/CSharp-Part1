using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while(a!=0 && b!=0)
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        if (a == 0)
        {
            Console.WriteLine("The greatest common divisor is: {0}",b);
        }
        else
        {
            Console.WriteLine("The greatest common divisor is: {0}", a);
        }
    }
}
