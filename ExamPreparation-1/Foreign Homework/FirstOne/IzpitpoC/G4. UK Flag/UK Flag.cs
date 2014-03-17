using System;

class UKFlag
{
    static void Main()
    {
        int flagN = int.Parse(Console.ReadLine());

        int outsideDot = 0;
        int innerDot =flagN/2-1;

        for (int i = 0; i < flagN/2; i++)
        {
            Console.Write(new string('.', outsideDot));
            Console.Write("\\");
            Console.Write(new string('.',innerDot)); 
            Console.Write("|");
            Console.Write(new string('.', innerDot));
            Console.Write("/");
            Console.Write(new string('.', outsideDot));
            Console.WriteLine();

            outsideDot++;
            innerDot--;
            
        }
        Console.Write(new string('-',(flagN)/2));
        Console.Write("*");
        Console.Write(new string('-',(flagN)/2));
        Console.WriteLine();

        outsideDot = flagN / 2-1;
        innerDot = 0;

        for (int i = 0; i < flagN/2; i++)
        {
            Console.Write(new string('.', outsideDot));
            Console.Write("/");
            Console.Write(new string('.',innerDot));
            Console.Write("|");
            Console.Write(new string('.', innerDot));
            Console.Write("\\");
            Console.Write(new string('.', outsideDot));
            Console.WriteLine();

            outsideDot--;
            innerDot++;
        }
    }
}

