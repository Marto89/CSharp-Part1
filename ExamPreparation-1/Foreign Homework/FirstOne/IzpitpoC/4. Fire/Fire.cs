using System;

class Fire
{
    static void Main()
    {
        int widhtN = int.Parse(Console.ReadLine());
        int count = 2;
        //string topLeft = new string('.', (widhtN - 2) / 2);
        //string topDiez = new string('#', 2);
        //string topRight = new string('.', (widhtN - 2) / 2);
        //Console.WriteLine(topLeft + topDiez + topRight);

        for (int i = 0 ; i < (widhtN * 3)/4-1; i++)
        {
            if (i < widhtN / 2)
            {
                Console.Write(new string('.', widhtN / 2 - 1 - i));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', widhtN / 2 - 1 - i));
                Console.WriteLine();

                if (i == widhtN / 2 - 1)
                {
                    Console.Write(new string('.', widhtN / 2 - 1 - i));
                    Console.Write("#");
                    Console.Write(new string('.', i * 2));
                    Console.Write("#");
                    Console.Write(new string('.', widhtN / 2 - 1 - i));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write(new string('.', 1 + i - widhtN / 2));
                Console.Write("#");
                Console.Write(new string('.', i * 2 - count * 2));
                Console.Write("#");
                Console.Write(new string('.', 1 + i - widhtN / 2));
                Console.WriteLine();
                count += 2;
            }

        }
        Console.WriteLine(new string('-',widhtN));

        for (int i = 0; i < widhtN/2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write (new string('\\', widhtN / 2-i));
            Console.Write (new string('/', widhtN / 2-i));
            Console.Write(new string('.', i));
            Console.WriteLine();
            
        }
    }
}

