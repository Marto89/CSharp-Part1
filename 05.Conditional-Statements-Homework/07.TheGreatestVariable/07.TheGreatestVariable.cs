using System;
//using System.Linq;

    class TheGreatestVariable
{
    static void Main()
    {
     //FIRST SOLUTION
     // double[] numbers = new double[5];
     // Console.WriteLine("Enter 5 numbers:");
     //
     // for (int i = 0; i < numbers.Length; i++)
     // {            
     //     numbers[i] = double.Parse(Console.ReadLine());
     // }
     //double greatest = numbers.Max();
     //Console.WriteLine("The greatest number is: {0}!",greatest);

       //SECOND SOLUTION
        Console.Write("Enter first number:");
        double a = double.Parse(Console.ReadLine());
       
        Console.Write("Enter second number:");
        double b = double.Parse(Console.ReadLine());
       
        Console.Write("Enter third number:");
        double c = double.Parse(Console.ReadLine());
       
        Console.Write("Enter fourth number:");
        double d = double.Parse(Console.ReadLine());
       
        Console.Write("Enter fifth number:");
        double e = double.Parse(Console.ReadLine());
       
        double big;
        big = a;
       
        if (big < b)
        {
            big = b;
        }
        if(big < c)
        {
            big = c;
        }
        if (big < d)
        {
            big = d;
        }
        if(big < e)
        {
            big = e;
        }
        Console.WriteLine("The greatest number is : {0}",big);
    }
}