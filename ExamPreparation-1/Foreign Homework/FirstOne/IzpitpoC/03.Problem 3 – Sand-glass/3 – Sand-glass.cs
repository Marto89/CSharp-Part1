using System;

class SandGlass
{
    static void Main()
    {
        int oddNumber = int.Parse(Console.ReadLine());

        char symbol = '.';
        char astericks = '*'; 

        for (int i = 0; i < oddNumber/2; i++)
        {
            Console.Write(new string(symbol,i));
            Console.Write(new string(astericks,oddNumber-2*i));
            Console.WriteLine(new string(symbol,i)); 
        }


       //Console.Write(new string(symbol,oddNumber/2));
       //Console.Write(astericks);
       //Console.Write(new string(symbol, oddNumber / 2));
       //Console.WriteLine();
       //

        for (int i = oddNumber/ 2 ; i >= 0 ; i--)
        {
            Console.Write(new string(symbol, i));
            Console.Write(new string(astericks, oddNumber - 2 * i));
            Console.WriteLine(new string(symbol, i));
        }
        
    }
}

