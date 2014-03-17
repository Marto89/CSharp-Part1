using System;

class RadiusOfACircle
{
    static void Main()
    {
        Console.Title = "02.RadiusOfACircle";
        Console.Write("Enter the radius of a circle: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * r * Math.PI;
        double area = Math.PI * Math.Pow(r,2);

        Console.WriteLine("The perimeter of a circle is: {0:F3} and the area's circle: {1:F3}!!!",perimeter,area);
    }
}
