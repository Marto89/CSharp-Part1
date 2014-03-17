using System;

class ForestRoad
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        char point ='.';
        char asteriks='*';

        for (int i = 0; i < width-1; i++)
        {
            Console.Write(new string(point,i));
            Console.Write(asteriks);
            Console.Write(new string(point,(width-1)-i));
            Console.WriteLine();
        }
       // Console.Write(new string(point,width-1));
       // Console.WriteLine(asteriks);
       //
        for (int i = width-1; i >=0; i--)
        {
            Console.Write(new string(point, i));
            Console.Write(asteriks);
            Console.Write(new string(point, (width - 1) - i));
            Console.WriteLine();
        }
    }
}
