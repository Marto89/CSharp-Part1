using System;

class SortRealValue
{
    static void Main()
    {
        Console.Write("Enter first real value:");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second real value:");
        double n2 =double.Parse(Console.ReadLine());

        Console.Write("Enter third real value:");
        double n3 = double.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            if (n1 > n3)
            {
                if (n2 > n3)
                {
                    Console.WriteLine("{0},{1},{2}", n1, n2, n3);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", n1, n3, n2);
                }
            }
            else
            {
                if (n3 > n2)
                {
                    Console.WriteLine("{0},{1},{2}", n3, n1, n2);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", n3, n2, n1);
                }
            }
        }
        else
        {
            if (n2 > n3)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("{0},{1},{2}", n2, n1, n3);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", n2, n3, n1);
                }                
            }
        }
       
    }
}