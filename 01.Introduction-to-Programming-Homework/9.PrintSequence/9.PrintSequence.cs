using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0,15}" , i + 2 );
            }
            else
            {
                Console.WriteLine("{0,15}",-( i + 2 ));
                Console.Title = ("9.PrintSequence");
            }
        }
    }
}