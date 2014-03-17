using System;

class SandGlass
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        char point = '.';
        char asteriks = '*';
        int heightHalf=height/2;

        for (int i = 0; i <heightHalf; i++)
        {
            Console.Write(new string(point, i));
            Console.Write(new string(asteriks,height-i*2));
            Console.Write(new string(point,i));
            Console.WriteLine();
        }
       // Console.Write(new string(point,heightHalf));
       // Console.Write(asteriks);
       // Console.WriteLine(new string(point, heightHalf));
       //
        for (int i = heightHalf; i >=0; i--)
        {
            Console.Write(new string(point, i));
            Console.Write(new string(asteriks, height - i * 2));
            Console.Write(new string(point, i));
            Console.WriteLine();
        }
    }
}
