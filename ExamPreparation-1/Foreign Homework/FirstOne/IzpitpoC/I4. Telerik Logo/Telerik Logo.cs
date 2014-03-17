using System;

class TelerikLogo
{
    static void Main(string[] args)
    {
        int logoX = int.Parse(Console.ReadLine());

        int widht = (logoX + logoX) + ((logoX / 2 + 1)) + ((logoX / 2 + 1)) - 3;
        int middleDots = widht - 2 * (logoX / 2 + 1);

        Console.Write(new string('.', logoX / 2));
        Console.Write("*");
        Console.Write(new string('.', middleDots));
        Console.Write("*");
        Console.WriteLine(new string('.', logoX / 2));
        int dots = 0;
        int horn = logoX / 2 - 1;
        for (int i = 1; i < logoX - 1; i++)
        {

            if (i <= logoX / 2)
            {
                Console.Write(new string('.', horn));

                Console.Write("*");

                Console.Write(new string('.', dots));

            }
            else
            {
                Console.Write(new string('.', logoX / 2));
            }

            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots - 2));
            middleDots -= 2;
            Console.Write("*");
            Console.Write(new string('.', i));

            if (i <= logoX / 2)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('.', horn));
                horn--;
                dots++;
            }
            else
            {
                Console.Write(new string('.', logoX / 2));
            }

            Console.WriteLine();

        }

        Console.Write(new string('.', widht / 2));
        Console.Write("*");
        Console.Write(new string('.', widht / 2));
        Console.WriteLine();

        for (int i = 1; i < logoX; i++)
        {
            Console.Write(new string('.', logoX / 2));
            Console.Write(new string('.', logoX - i - 1));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            middleDots += 2;
            Console.Write("*");
            Console.Write(new string('.', logoX - i - 1));
            Console.Write(new string('.', logoX / 2));
            Console.WriteLine();

        }

        for (int i = 2; i < logoX; i++)
        {
            Console.Write(new string('.', logoX / 2));
            Console.Write(new string('.', i - 1));
            Console.Write("*");
            Console.Write(new string('.', middleDots - 4));
            middleDots -= 2;
            Console.Write("*");
            Console.Write(new string('.', i - 1));
            Console.Write(new string('.', logoX / 2));
            Console.WriteLine();
        }
        Console.Write(new string('.', widht / 2));
        Console.Write("*");
        Console.Write(new string('.', widht / 2));
        Console.WriteLine();
    }
}

