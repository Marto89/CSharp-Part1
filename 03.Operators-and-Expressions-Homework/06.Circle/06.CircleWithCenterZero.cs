using System;

class CircleWithCenterZero
{
    static void Main()
    {
        Console.Title = "06.CircleWithCenterZero";
        Console.Write("Enter the value of x:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of y:");
        double y = double.Parse(Console.ReadLine());
        double r = 5;
        

        if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(r, 2))
        {
            Console.WriteLine("The point is in the circle!");
        }
        else
        {
            Console.WriteLine("The point is out of the circle!");
        }
    }
}
