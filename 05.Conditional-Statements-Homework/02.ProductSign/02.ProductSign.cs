using System;

class ProductSign
{
    static void Main()
    {
        Console.Write("Enter first number:");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Enter third number:");
        double n3 = double.Parse(Console.ReadLine());

        if ((n1 < 0 && n2 > 0 && n3 > 0) || (n1 > 0 && n2 < 0 && n3 > 0) || (n1 > 0 && n2>0 && n3 < 0) || (n1 < 0 && n2 < 0 && n3 < 0))
        {
            Console.WriteLine("The product of the 3 numbers is negative!");
        }
        else if ((n1 == 0) || (n2 == 0) || (n3 == 0))
        {
            Console.WriteLine("The product of the 3 numbers is zero!");
        }
        else
        {
            Console.WriteLine("The product of the 3 numbers is positive!");
        }
    }
}
