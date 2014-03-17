using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Title = "13.ExchangeBits";
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());

        int mask1 = 7 << 24;
        int mask2 = 7 << 3;

        int getNumbers1 = mask1 & n;
        int getNumbers2 = mask2 & n;
        int change = (n & ~mask1) & ~mask2;


        int mask3 = (getNumbers1 >> 3) << 24;
        int mask4 = (getNumbers2 >> 3) << 24;
        int result = (change | mask3) | mask4;
        Console.WriteLine(result);
     
    }
}
