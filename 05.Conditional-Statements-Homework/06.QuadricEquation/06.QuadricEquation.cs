using System;

class QuadricEquation
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());

        double x1;
        double x2;

        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("The quadratic equation has not real roots!");
        }
        if (d == 0)
        {
            x1 = -b / 2 * a;
            Console.WriteLine("The quadratic equation has one real roots->({0})!", x1);
        }
        else
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The quadratic equation has two real roots->({0},{1})!", x1, x2);
        }        

    }
}
