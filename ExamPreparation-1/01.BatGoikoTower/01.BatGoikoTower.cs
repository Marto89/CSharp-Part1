using System;

    class BatGoikoTower
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            char point='.';
            char slash = '/';
            char backslash = '\\';
            char dash = '-';
            int line = 1;
            int counter = 2;
            
            //First Solution

            for (int i = 0; i < height; i++)
            {
                char insidePoint = '.';
                if (i == line)
                {
                    insidePoint = dash;
                    line += counter;
                    counter++;
                }   
                Console.Write(new string(point, height - i - 1));
                Console.Write(slash);             
                Console.Write(new string(insidePoint, i * 2));
                Console.Write(backslash);
                Console.WriteLine(new string(point, height - i - 1));
            }

            //Second Solution

           // for (int i = 0; i <height; i++)
           // {
           //     Console.Write(new string(point,height-i-1));
           //     Console.Write(slash);
           //     if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
           //     {
           //         Console.Write(new string(dash, i * 2));
           //     }
           //     else
           //     {
           //         Console.Write(new string(point,i*2));
           //     }
           //     Console.Write(backslash);
           //     Console.WriteLine(new string(point, height - i - 1));
           // }
        }
    }
