using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {

        string number = Console.ReadLine();
        ulong sum = 0;
        ulong sum2;

        for (int i = 0; i <number.Length; i++)
        {
            if ((number[i] >= '0') && (number[i]<='9'))
            {
                sum += ulong.Parse(number[i].ToString());
            }
        }
         while(sum>9)
         {
             sum2 = 0;
             while (sum != 0)
             {
                 sum2 += sum % 10;
                 sum /= 10;
             }
             sum = sum2;
         }
        Console.WriteLine(sum);
    }
}
