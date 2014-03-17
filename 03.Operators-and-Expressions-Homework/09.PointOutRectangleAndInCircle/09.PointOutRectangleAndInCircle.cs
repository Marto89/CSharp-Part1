using System;

class PointOutRectangleAndInCircle
{
    static void Main()
    {
        Console.Title = "09.PointOutRectangleAndInCircle";
        Console.Write("Enter the value of x:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of y:");
        double y = double.Parse(Console.ReadLine());
        int r = 3;
   
        bool areaCircle = (Math.Pow((x-1),2) + Math.Pow((y-1),2)<=Math.Pow(r,2));
        bool areaRectangle = (( -1 <= x ) && ( 5 >= x ) && ( -1 <= y ) && ( 1 >= y ));

        Console.Write(areaCircle ? "The point is within the circle and " : "The point is outside the circle and ");
        Console.WriteLine(areaRectangle ? "within the rectangle!" : "outside the rectangle!");

    }
}