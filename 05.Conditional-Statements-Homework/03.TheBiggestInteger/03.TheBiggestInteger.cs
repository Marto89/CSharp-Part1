using System;

class TheBiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int n3 = int.Parse(Console.ReadLine());

        if ((n1 >= n2) && (n1 >= n3))
        {
            Console.WriteLine("First number ({0}) is the biggest!", n1);
        }
        else
        {
            if ((n2 >= n1) && (n2 >= n3))
            {
                Console.WriteLine("Second number ({0}) is the biggest!", n2);
            }
            else
            {
                Console.WriteLine("Third number ({0}) is the biggest!", n3);
            }
        }
    }
}
