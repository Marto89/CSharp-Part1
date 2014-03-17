using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a : ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b : ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c : ");
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double discriminantD = Math.Pow(b, 2) - (4 * a * c);
        if (discriminantD > 0)
        {
            x1= (-b + Math.Sqrt(discriminantD)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminantD)) / (2 * a);
            Console.WriteLine("Quadratic Equation has two real roots: {0} , {1}",x1,x2);
        }
        else if (discriminantD == 0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("Quadratic Equation has one real roots: {0} ",x1);
        }
        else
        {
            Console.WriteLine("Quadratic Equation has no real roots!");
        }
    }
}
