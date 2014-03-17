using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        
        double res = Math.Max(a,b);
        Console.WriteLine("The greater number from {0} and {1} is: {2}",a,b,res);       
    }
}
