using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Title = ("04.ThirdDigit");
        Console.Write("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        int num2 = number / 100;
        bool num3 = num2 % 10 == 7;

        Console.WriteLine("{0}->{1}",number,num3); 
    }
}
