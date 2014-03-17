using System;

class CalculatesRectanglesArea
{
    static void Main()
    {
        Console.Title = ("03.CalculatesRectangle’sArea");
        Console.Write("Enter the widht:");
        int widht = int.Parse(Console.ReadLine());
        Console.Write("Enter the height:");
        int height = int.Parse(Console.ReadLine());
        int area = widht * height;

        Console.WriteLine("Rectangle’s area is:{0}",area);
    }
}
