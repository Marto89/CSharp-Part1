using System;

class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int count = 1;

        for (int i = 0; i < height; i++)
        {
            if (i == 2 || i == 4 || i == 5 || i == 7 || i == 8 || i == 9 || i == 11 || i == 12 || i == 13 || i == 14 || i == 16 || i == 17 || i == 18 || i == 19 || i == 20 || i == 22 || i == 23 || i == 24 || i == 25 || i == 26 || i == 27 || i == 29 || i == 30 || i == 31 || i == 32 || i == 33 || i == 34 || i == 35 || i == 37 || i == 38 || i == 39 || i == 40 || i == 41 || i == 42 || i == 43 || i == 44 || i == 46)
            {
                Console.Write(new string('.', height - 1 - i));
                Console.Write('/');
                Console.Write(new string('.', i * 2));
                Console.Write('\\');
                Console.Write(new string('.', height - 1-i ));
                Console.WriteLine();
            }
            else

            {
                Console.Write(new string('.',height-1-i));
                Console.Write('/');
                Console.Write(new string('-', i*2 ));
                Console.Write('\\');

                Console.Write(new string('.', height - 1 - i));
                Console.WriteLine();
            }
        }

    }
}

