using System;

class ExchangeInteger
{
    static void Main()
    {
        Console.Title = (" 11.ExchangeInteger");
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a={0}", a);
        Console.WriteLine("b={0}", b);
        
    }
}
