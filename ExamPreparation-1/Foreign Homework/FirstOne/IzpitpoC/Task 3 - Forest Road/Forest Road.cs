using System;

class ForestRoad
{
    static void Main()
    {
        int widhtN = int.Parse(Console.ReadLine());

        int height = 2 * widhtN + 1;
        string symbol = "*";

        for (int i = 0; i < widhtN ; i++)
        {
            Console.Write(new string ( '.' ,i));
            Console.Write(symbol);
            Console.WriteLine(new string ('.',(widhtN-1)-i));   
        }

        for (int i = widhtN -1; i > 0; i--)
        {
            Console.Write (new string('.' , i-1));
            Console.Write (symbol);
            Console.WriteLine(new string ('.',(widhtN-i)));
        }
    }
}

