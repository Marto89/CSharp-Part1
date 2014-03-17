using System;

class FirTree
{
    static void Main()
    {
        int heighN = int.Parse(Console.ReadLine());
        int newheighN = heighN - 1;
        for (int i = 0; i < newheighN ; i++)
        {
            Console.Write(new string ('.',newheighN -1 -i));
            Console.Write(new string ('*', i+i+1));
            Console.Write(new string('.', newheighN - 1 - i));
            Console.WriteLine();
        }
        Console.Write(new string('.', heighN - 2 ));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', heighN - 2));
        Console.WriteLine();


        

    }
}

