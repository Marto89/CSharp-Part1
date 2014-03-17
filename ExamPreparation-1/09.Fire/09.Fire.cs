using System;

class Fire
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int halfWidth=width/2;
        char numberSign = '#';
        char point = '.';
        char dash = '-';
        char slash='/';
        char backslash='\\';

        for (int i = 0; i <halfWidth; i++)
        {
            Console.Write(new string(point,halfWidth-i-1));
            Console.Write(numberSign);
            Console.Write(new string(point,i*2));
            Console.Write(numberSign);
            Console.WriteLine(new string(point, halfWidth - i - 1));
        }

        for (int i = 1; i <=halfWidth/2; i++)
        {
            Console.Write(new string(point,i-1));
            Console.Write(numberSign);
            Console.Write(new string(point,width-2*i));
            Console.Write(numberSign);
            Console.WriteLine(new string(point, i - 1));
        }


        Console.WriteLine(new string(dash,width));

        for (int i=0; i <halfWidth; i++)
        {          
            Console.Write(new string(point,i));
            Console.Write(new string(backslash, halfWidth - i));
            Console.Write(new string(slash, halfWidth - i));
            Console.WriteLine(new string(point, i));
        }
    }
}
