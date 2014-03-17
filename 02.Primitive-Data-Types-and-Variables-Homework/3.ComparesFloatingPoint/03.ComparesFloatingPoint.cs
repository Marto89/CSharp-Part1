using System;

class ComparesFloatingPoint
{
    static void Main()
    {
        Console.Title = ("3.ComparesFloatingPoint");
        Console.WriteLine("Please enter the first real number:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the second real number:");
        double number2 = double.Parse(Console.ReadLine());

        bool comparing = (Math.Abs(number1 - number2)<0.000001d);
        Console.WriteLine("The two numbers are equal: ({0};{1})->{2} ", number1, number2, comparing);      
    }
}