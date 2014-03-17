using System;

class FirTree
{
    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());
        char point='.';
        char asteriks='*';
        int counter = 1;

        for (int i = 1; i <=height-1; i++)
        {
            Console.Write(new string(point,height-1-i));
            if (i > 1)
            {
                Console.Write(new string(asteriks, i + counter));
                counter++;
            }
            else
            {
                Console.Write(asteriks);
            }
            Console.Write(new string(point, height - 1 - i));
            Console.WriteLine();          
        }
        Console.Write(new string(point,height-2));
        Console.Write(asteriks);
        Console.Write(new string(point, height - 2));
            
    }
}
