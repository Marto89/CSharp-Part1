using System;

class ExchangeValue
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            n2 = n1 + n2;
            n1 = n2 - n1;
            n2 = n2 - n1;
        }
        Console.WriteLine("->{0},{1}", n1, n2);
    }
}
