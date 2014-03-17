using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Title = "08.TrapezoidArea";
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h:");
        double h = double.Parse(Console.ReadLine());

        double sum = ((a + b) / 2) * h;
        Console.WriteLine("The trapezoid's area is:  {0} ", sum);
    }
}